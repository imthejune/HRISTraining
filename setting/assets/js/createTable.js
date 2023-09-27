var CreateTable = function (obj) {
  var self;

  /**
   * target : object frontend
   * @param {*} target
   */
  let createTable = function (target) {
    this.app = target.app;
    this.list = target.list;
    this.btnCheck = $('a[role="button"][data-check="true"]');
    this.btnStart = $('a[role="button"][data-start="true"]');
    this.result;
    self = $.extend({}, this);

    self.loading();
  };

  createTable.prototype = {
    loading() {
      let { app, renderList, list,btnCheck,btnStart } = self;

      let data = {
        url: `${URLEND.base}data/table`,
      };

    
      btnCheck.click(function () {
        (data.process = "load"),
          Is.request(data, function (target) {

            if (target.data.length > 0) {
              renderList(app, target);
              btnStart.removeClass('disabled')
            }
           
          });
      });

      btnStart.click(function () {
        (data.process = "createScript"),
          Is.request(data, function (target) {
            console.log(target);
            renderList(list, target);
          });
      });
    },
    renderList(app, obj) {
      app.empty();

      $.map(obj.data, function (e) {
        // if (!e.status) {
        //   return false;
        // }
        /*  list.append(`<li id="${e.keyuuid}" class="list-group-item" >${e.table}</li>`)*/
        let st = "badge-danger";

        if (e.status) {
          st = "badge-info";
        }

        app.append(` <li id="${e.keyuuid}" class="list-group-item d-flex justify-content-between align-items-center">
                            <span class="chk" style=""></span>
                            <label class="col-10 mb-0" >${e.table}</label>
                            <span class="col-1 badge ${st} badge-pill"> </span>
                          </li>`);
      });

      app.find(" > li").on("click", function () {
        app.find("> li.active").removeClass("active");
        $(this).toggleClass("active");
        $(this).toggleClass("selected");

        // let index = obj.data.find((x)=>x.keyuuid === $(this).attr('id'));

        // renderScript(index);
      });
    },
    renderScript(e) {
      let { typeColumn } = self;

      let htmp = ``;
      // $.map(data, function (e) {
      let col = e["column"];

      let column = ``;

      if (e["column"]) {
        $.grep(col, function (c) {
          column += `     [${c["Name"]}] ${typeColumn(c)}, \n`;
        });
      }

      let primary = "";

      if (e["primary"].length > 0) {
        let key = "";

        key = e["primary"].toString(",");

        primary = ` CONSTRAINT [PK_${e["table"]}] PRIMARY KEY CLUSTERED 
                            ([${key}] ASC ) ON [PRIMARY]`;
      }

      htmp += ` CREATE TABLE [dbo].[${e["table"]}]( \n${column}\n ${primary}) ON [PRIMARY] \n `;

      //htmp += '<br/><hr/><br/>';

      //  })

      $("#jsonObject").text(htmp);
      //document.getElementById("jsonObject").innerHTML = JSON.stringify(models);
    },
    typeColumn(target) {
      let typeText = "";

      let IsNotNull = "null";

      if (target["Albe"] === "NO") {
        IsNotNull = "IDENTITY(1,1) NOT NULL";
      }

      switch (target["Type"]) {
        case "numeric":
          typeText = `[${target["Type"]}](${target["Numeric"]}, ${
            target["Scale"] || 0
          }) ${IsNotNull}`;
          break;
        case ("nvarchar", "nchar", "varchar"):
          typeText = `[${target["Type"]}](${target["Character"]}) ${IsNotNull}`;
          break;
        case ("bit", "uniqueidentifier", "float", "int", "datetime"):
          if (
            target["Type"] === "uniqueidentifier" &&
            target["Able"] === "NO"
          ) {
            typeText = `[${target["Type"]}] NOT NULL`;
          } else {
            typeText = `[${target["Type"]}] ${IsNotNull}`;
          }
        default:
          typeText = target["Type"];
          break;
      }

      return typeText;
    },
  };

  return new createTable(obj);
};

"use strict";

var WPtemplate = function (obj) {
  var self;

  /**
   *
   * @param {*} e type object - {url}
   */
  var template = function (e) {
    if (!e.url) {
      console.log("not url pages");
      return false;
    }
    //: default

    this.url = e.url;
    this.version = "1.0.0";

    if (e.mainName) this.mainName = e.mainName;

    if (e.uuid) this.uuid = e.uuid;

    if (e.content) {
      // if (typeof e.content === "object" && e.content.length > 0) {
      this.content = e.content;
      // }
    }

    if (e.render) {
      this.render = e.render;
    }

    self = $.extend({}, this);
  };

  let parseHTML = function (html) {
    var t = document.createElement("template");
    t.innerHTML = html;
    return t.content.cloneNode(true);
  };

  template.prototype = {
    modal(callback) {
      let parser = new DOMParser();

      $.get(self.url, function (data, a, b) {
        let root = parser.parseFromString(data, "text/html");

        self.name = self.mainName + self.uuid;

        let contents = root.querySelector("#content");

        let html = parseHTML(contents.innerHTML);

        let head = document.getElementsByTagName("head")[0];
        let body = document.getElementsByTagName("body")[0];

        
        let temp = {
          main: html.querySelectorAll("main")[0],
          script: html.querySelectorAll("script"),
          style: html.querySelectorAll("style"),
          link: html.querySelectorAll('link[rel="stylesheet"]'),
        };
      
        temp.main.id += self.uuid;
          let tempName = {};
        
        if (typeof self.content === "string") {
          
          let contentName = temp.main.querySelector(self.content);
          
          let idName = contentName.id;
          contentName.id += self.uuid;
          tempName[idName] = contentName.id;
        } else if (typeof self.content ==='object') {

          self.content.forEach((e)=>{
            let contentName = temp.main.querySelector(`#${e}`);
          
            let idName = contentName.id;
            contentName.id += `-${self.uuid}`;
            tempName[idName] = contentName.id;
          })
          
        }

        if (head) {
          if (temp.link) {
            if (temp.link.length > 0) {
              temp.link.forEach((element) => {
                head.appendChild(element);
              });
            }
          }

          if (temp.style.length > 0) {
            temp.style.forEach((element) => {
              head.appendChild(element);
            });
          }
        }

        Is.svg(temp.main)
       
        self.render.append(temp.main);
        if (body) {
          if (temp.script.length > 0) {
            temp.script.forEach((element) => {
              let script = document.createElement("script");
              script.type = "text/javascript";
              script.innerHTML = element.textContent;
              script.id = "script-" + self.uuid;
              body.appendChild(script);
            });
          }
        }

        callback(tempName);
      });
    },
    pages(callback) {
      let parser = new DOMParser();

      $.get(self.url, function (data, a, b) {
        let root = parser.parseFromString(data, "text/html");

        self.name = self.mainName + self.uuid;

        let contents = root.querySelector("#content");

        let html = parseHTML(contents.innerHTML);

        let head = document.getElementsByTagName("head")[0];
        let body = document.getElementsByTagName("body")[0];

        let temp = {
          main: html.querySelectorAll("main")[0],
          script: html.querySelectorAll("script"),
          style: html.querySelectorAll("style"),
          link: html.querySelectorAll('link[rel="stylesheet"]'),
        };

        temp.main.id += self.uuid;

        temp.main.querySelector(self.content).id = self.name;

        if (head) {
          if (temp.link) {
            if (temp.link.length > 0) {
              temp.link.forEach((element) => {
                head.appendChild(element);
              });
            }
          }

          if (temp.style.length > 0) {
            temp.style.forEach((element) => {
              head.appendChild(element);
            });
          }
        }
        self.render.append(temp.main);
        if (body) {
          if (temp.script.length > 0) {
            temp.script.forEach((element) => {
              let script = document.createElement("script");
              script.type = "text/javascript";
              script.innerHTML = element.textContent;
              script.id = "script-" + self.uuid;
              body.appendChild(script);
            });
          }
        }

        callback({
          name: self.name,
        });
      });
    },
    render(page, callback) {
      var parser = new DOMParser();

      $.get(page, function (data, a, b) {
        var root = parser.parseFromString(data, "text/html");

        var contents = root.querySelector("#content");

        callback(b.status != 200 ? false : true, parseHTML(contents.innerHTML));
      });
    },

    loading(callback) {
      let parser = new DOMParser();

      $.get(self.url, function (data, a, b) {
        let root = parser.parseFromString(data, "text/html");

        let contents = root.querySelector("#content");

        let html = parseHTML(contents.innerHTML);

        let t = {
          main: html.querySelectorAll("main"),
          script: html.querySelectorAll("script"),
          style: html.querySelectorAll("style"),
          link: html.querySelectorAll('link[rel="stylesheet"]'),
        };

        callback(t);
      });
    },
  };

  return new template(obj);
};

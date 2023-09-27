<%@ Page Language="VB" AutoEventWireup="false" CodeFile="table.component.aspx.vb" Inherits="setting_components_table_component" %>

<template id="content">

    <style type="text/css">
        .tn-list.list-group .list-group-item {
            margin: .5rem;
            border: none;
            cursor: pointer;
            transition: all ease 3ms;
            color: #a7a7a7;
        }

            .tn-list.list-group .list-group-item span, label {
                cursor: pointer;
            }

        .tn-list.list-group > li > .chk {
            width: 10px;
            height: 10px;
            background: #e1e1e1;
            border-radius: 50%;
        }

        .tn-list.list-group > li.selected > .chk {
            background: #a7a7a7;
            color: #a7a7a7;
        }

        .tn-list.list-group .list-group-item.active {
            background: #f5f5f5;
            color: #a7a7a7;
            border-radius: 10px;
        }

        .tn-list.list-group .list-group-item:hover {
            background: #f5f5f5;
            border-radius: 10px;
        }
    </style>

    <main id="content-main" class="w-100">
        <div class="card border-0 w-100" id="content-table">
            <div class="card-body">
                <div class="card-header  bg-transparent mb-2">
                    Table 
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="jumbotron bg-transparent text-center h-100" style="display: flex;align-items: center;justify-content: center;">
                            <div>
                                  <h4 class="display-4">Installer, table!</h4>
                             <p class="lead">Verify and create a Training system repository.</p>
                            <%--<hr class="my-4">--%>
                            <p class="lead mb-0">
                                <a class="btn btn-primary btn-md disabled"  role="button" data-start="true">Start</a>
                                <a class="btn btn-primary btn-md" role="button" data-check="true">Check</a>
                            </p>
                            </div>
                          
                        </div>

                    </div>
                    <div class="col-md-6">
                        <div class="card border-0 mb-2">

                            <div class="card-body bg-light text-white" style="height: 200px; padding: 1rem; overflow: auto;">
                                <%--<div class=" w-100" style="height: 350px; padding: 1rem; overflow: auto">
                                    <ul class="tn-list list-group list-group-flush" id="listTable">
                                    </ul>
                                </div>
                                <p id="jsonObject"></p>--%>
                                 <ul class="tn-list list-group list-group-flush" id="listTable">
                                    </ul>
                            </div>
                        </div>
                        <div class="card border-0">

                            <div class="card-body bg-light text-white" style="height: 200px; padding: 1rem; overflow: auto;">
                                <%--<div class=" w-100" style="height: 350px; padding: 1rem; overflow: auto">
                                    <ul class="tn-list list-group list-group-flush" id="listTable">
                                    </ul>
                                </div>
                                <p id="jsonObject"></p>--%>
                                 <ul class="tn-list list-group list-group-flush" id="afterTable">
                                    </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </main>


    <script type="text/javascript">

        if (!transfer.controller) {
            transfer.controller = {};
        }

        transfer.controller.createTable = function (obj) {
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
                    let { app, renderList, list, btnCheck, btnStart } = self;

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

                },
                renderScript(e) {
                    let { typeColumn } = self;

                    let htmp = ``;
                  
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

                    $("#jsonObject").text(htmp);
                  
                },
                typeColumn(target) {
                    let typeText = "";

                    let IsNotNull = "null";

                    if (target["Albe"] === "NO") {
                        IsNotNull = "IDENTITY(1,1) NOT NULL";
                    }

                    switch (target["Type"]) {
                        case "numeric":
                            typeText = `[${target["Type"]}](${target["Numeric"]}, ${target["Scale"] || 0
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

    </script>
    <script type="text/javascript">
        new transfer.controller.createTable({
            app: $('#listTable'),
            list: $('#afterTable')
        })



        $(function () {

          

        });

    </script>
</template>

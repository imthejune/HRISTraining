<%@ Page Language="VB" AutoEventWireup="false" CodeFile="config.component.aspx.vb" Inherits="setting_components_config_component" %>

<template id="content">

    <style type="text/css">
 
    </style>

    <main id="content-main" class="w-100">
        <div class="card border-0 w-100" id="content-table">
            <div class="card-body mb-4">
                <%-- <div class="card-header  bg-transparent mb-2 text-muted">
                    Connection
                </div>--%>

                <div class="container">

                    <div class="card border-0">
                        <div class="card-body">
                            <div class="card-header border-0 bg-transparent mb-2 px-0 py-1">
                                <div class="d-flex justify-content-between">
                                      <h6 class="card-subtitle mb-2 text-muted">Base To </h6>
                                      <button data-btn-claer="true" class="btn btn-info btn-sm btn-label">Clear database</button>
                                </div>
                              
                            </div>

                            <div class="alert alert-warning alert-dismissible fade show" role="alert">
                                <strong>Connection !</strong> เริ่มต้นจะใช้ค่าจาก Registy ที่โปรเจคอ่านมาได้
                              <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                                  <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <form class="px-3" name="BaseTo">

                                <div class="form-row mb-2">
                                    <div class="form-group col-md-6">
                                        <h6 for="servername">Server name</h6>
                                        <input type="text" class="form-control form-control-sm" name="servername" placeholder="Server name">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <h6 for="database">Database</h6>
                                        <input type="text" class="form-control form-control-sm" name="database" placeholder="Database">
                                    </div>
                                </div>
                                <div class="form-row mb-2">
                                    <div class="form-group col-md-6">
                                        <h6 for="username">Username</h6>
                                        <input type="text" class="form-control form-control-sm" name="username" placeholder="Username">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <h6 for="password">Password</h6>
                                        <input type="text" class="form-control form-control-sm" name="password" placeholder="Password">
                                    </div>
                                </div>

                            </form>
                        </div>
                    </div>

                    <div class="card border-0">
                        <div class="card-body">

                            <div class="card-header border-0  bg-transparent mb-2 px-0 py-1">
                                <h6 class="card-subtitle mb-2 text-muted">Base For</h6>
                            </div>

                            <form class="px-3" name="BaseFor">

                                <div class="form-row mb-2">
                                    <div class="form-group col-md-6">
                                        <h6 for="servername">Server name</h6>
                                        <input type="text" class="form-control form-control-sm" name="servername" placeholder="Server name">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <h6 for="database">Database</h6>
                                        <input type="text" class="form-control form-control-sm" name="database" placeholder="Database">
                                    </div>
                                </div>
                                <div class="form-row mb-2">
                                    <div class="form-group col-md-6">
                                        <h6 for="username">Username</h6>
                                        <input type="text" class="form-control" name="username" placeholder="Username">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <h6 for="password">Password</h6>
                                        <input type="text" class="form-control" name="password" placeholder="Password">
                                    </div>
                                </div>

                            </form>
                        </div>
                    </div>


                    <div class="text-right px-4">
                        <button data-submit="true" class="btn btn-info btn-sm btn-label">save</button>
                        <button class="btn btn-outline-info btn-sm btn-label">cancel</button>
                    </div>
                </div>
            </div>
            
        </div>
    </main>

    <script type="text/javascript">


        if (!transfer.controller) {
            transfer.controller = {};
        }

        if (!transfer.controller.config) {
            transfer.controller.config = {};
        }


        transfer.controller.config = function (obj) {
            var self;

            let controller = function (e) {

                self = $.extend(this, {
                    element: {
                        BaseTo: document.querySelectorAll('[name="BaseTo"]')[0],
                        BaseFor: document.querySelectorAll('[name="BaseFor"]')[0]
                    },
                    data: {},
                    panel: e.panel
                })

                self.Loading()
            }

            controller.prototype = {
                Loading() {

                    let { element, KeyForm, onsubmit, LoadForm, clearBase } = self;

                    element.BaseTo.addEventListener("keyup", KeyForm)
                    element.BaseFor.addEventListener("keyup", KeyForm)
                    LoadForm();
                    clearBase();
                    onsubmit();
                },
                clearBase() {

                    let { panel } = self;

                    panel.event('[data-btn-claer="true"]', function (e) {
                        
                        let { request } = Is;


                        let data = {
                            url: `${URLEND.base}data/setup-config`,
                            process: "cleardatabase"
                        };

                        request(data, function (target) {

                            let { data } = target;

                            console.log(target);

                        });
                    })
                },

                LoadForm() {
                    let { element, data: dataInput } = self;
                    let { request } = Is;
                    let { map } = $

                    let data = {
                        url: `${URLEND.base}data/setup-config`,
                        process: "InitLoad"
                    };


                    request(data, function (target) {

                        let { data } = target;

                        map(data, function (e, k) {
                            dataInput[k] = e
                            map(e, function (val, key) {

                                let ele = element[k];

                                if (val === null) {
                                    return false;
                                }

                                ele.querySelectorAll(`[name="${key}"]`)[0].value = val

                            })

                        })
                      
                    });

                },
                KeyForm(e) {

                    let { data } = self;
                    let target = e.target;

                    let formid = target.form.name;


                    if (!data[formid]) {
                        data[formid] = {}
                    }

                    data[formid][target.getAttribute('name')] = target.value;


                },

                onsubmit() {

                    let { data: dataForm, panel } = self;

                    panel.event('button[data-submit="true"]', function (e) {
                      
                        let { request } = Is;
                        

                        let data = {
                            url: `${URLEND.base}data/setup-config`,
                            process: "Update",
                            store: JSON.stringify(dataForm)
                        };


                        request(data, function (target) {

                            let { data } = target;

                           /* console.log(data);*/

                        });


                    })

                }
            };


            return new controller(obj);
        }

        new transfer.controller.config({
            panel: document.querySelectorAll('[id^="content-table"]')[0]
        });


    </script>
</template>


<%@ Page Language="VB" AutoEventWireup="false" CodeFile="transfer.component.aspx.vb" Inherits="setting_components_transfer_component" %>

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

        .tn-box {
            height: 100px;
            background: #f1f1f1;
            width: 100%;
            border-radius: 8px;
            display: flex;
            flex-flow: column;
            align-items: center;
            justify-content: center;
        }

        .tn-card_scroll.card-body {
            padding: 1rem;
            overflow: auto;
        }
    </style>

    <main id="content-main" class="w-100">
        <div class="card border-0 w-100" id="content-table">
            <div class="card-body">
                <div class="card-header  bg-transparent mb-2">
                    Transfer
                </div>

                <div class="row">
                    <div class="col-md-5" id="task-list" data-type="task">
                        <div class="card border-0 mb-2 d-none">
                            <div class="card-header bg-transparent border-0 pb-0 ">
                                Main
                            </div>
                            <div class="card-body tn-card_scroll" style="height: 100px;">
                                <ul class="tn-list list-group list-group-flush" data-task="main">
                                </ul>
                            </div>
                        </div>
                        <div class="card border-0 mb-2">
                            <div class="card-header bg-transparent border-0 pb-0">
                                Transection
                            </div>
                            <div class="card-body tn-card_scroll" style="height: 150px;">
                                <ul class="tn-list list-group list-group-flush" data-task="transection">
                                </ul>
                            </div>
                        </div>
                        <div class="card border-0 mb-2 ">
                            <div class="card-header bg-transparent border-0 pb-0">
                                Masters
                            </div>
                            <div class="card-body tn-card_scroll" style="height:250px;">

                                <ul class="tn-list list-group list-group-flush" data-task="master">
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-7">
                        <div class="jumbotron bg-transparent text-center pb-0 pt-3">
                            <div id="board-report" data-type="board" style="display: flex; align-items: center; justify-content: center; flex-flow: column;">
                                <p>Report</p>
                                <div class="row mb-3 w-100">
                                    <div class="col-4">
                                        <div class="tn-box" data-board="check">
                                            <p>0</p>
                                            <span>Rawdata</span>
                                        </div>
                                    </div>
                                    <div class="col-4">
                                        <div class="tn-box" data-board="succeed">
                                            <p>0</p>
                                            <span>Succeed</span>
                                        </div>
                                    </div>
                                    <div class="col-4">
                                        <div class="tn-box" data-board="error">
                                            <p>0</p>
                                            <span>Error</span>
                                        </div>
                                    </div>

                                </div>
                                <p class="lead mb-0">
                                    <a class="btn btn-primary btn-md disabled" role="button" data-check="true">Check</a>
                                    <a class="btn btn-primary btn-md disabled" role="button" data-start="true">Start</a>
                                </p>

                            </div>

                        </div>
                        <div class="card border-0 mb-2">
                            <div class="card-header bg-transparent border-0">
                                Event log
                            </div>
                            <div class="card-body border" style="height: 250px; padding: 1rem; overflow: auto;">

                                <ul class="list-group list-group-flush" id="eventlog">
                                    <%-- <li class="list-group-item">alksdjf;askldf</li>--%>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </main>
    <script type="text/javascript">

        $.fn.child = function (value, type = '') {

            if (type === '') {
                type = `${this.data().type}`;
            }

            return this.find(`[data-${type}="${value}"]`)
        }

        Array.prototype.sum = function (prop) {
            var total = 0
            for (var i = 0, _len = this.length; i < _len; i++) {
                total += this[i][prop]
            }
            return total
        }

       

        transfer.transferController = function (obj) {

            var self;

            let transfer = function (ele) {
                this.selectedkey = '';
                this.wait = $('.wp-ringer');
                self = $.extend({}, this, ele)

                self.loading();

            }

            transfer.prototype = {
                loading() {

                    let { tasking, eventLi, checkUp, startUp } = self;
                    let data = {
                        url: `${URLEND.base}data/transfer`,
                        process: 'init'
                    };

                    Is.request(data, function (target) {

                        let data = target.data;

                        tasking(data);
                        eventLi();
                        checkUp();
                        startUp();
                    });

                },
                tasking(data) {

                    let { task } = self;


                    if (data.main.length > 0) {

                        let ele = task.child('main');

                        ele.empty();

                        $.map(data.main, function (item) {
                            ele.append(`<li id="${item.code}" data-key="${item.template}" class="list-group-item py-2">${item.template}</li>`)
                        })
                    }

                    if (data.transection.length > 0) {
                        let ele = task.child('transection');

                        ele.empty();

                        $.map(data.transection, function (item) {

                            ele.append(`<li id="${item.code}" data-key="${item.template}" class="list-group-item py-2">${item.title}</li>`)
                        })
                    }

                    if (data.master.length > 0) {
                        let ele = task.child('master');

                        ele.empty();

                        $.map(data.master, function (item) {

                            ele.append(`<li id="${item.code}" data-key="${item.template}" class="list-group-item py-2">${item.template}</li>`)
                        })
                    }

                },
                eventLi() {

                    let { task, board, getData, eventlog } = self;

                    let ele = task.find('ul > li')

                    ele.click(function (e) {
                        task.find('ul > li.active').removeClass('active');
                        self.waiting();
                        let safe = $(this);

                        eventlog.empty();

                        safe.toggleClass('active');

                        self.selectedkey = safe.data().key;

                        getData({
                            code: safe.attr('id'),
                            key: safe.data().key,
                            type: safe.parent('ul').data().task
                        })


                    });
                },
                getData(target) {

                    let { code, type, key } = target;
                    let { request } = Is;


                    let data = {
                        url: `${URLEND.base}data/transfer`,
                        process: type,
                        code: code
                    };

                    request(data, function (target) {

                        let { data } = target;



                        self.board.child("check").find('p').text(data);
                        self.board.child("succeed", 'board').find('p').text(0)
                        self.board.child("error", 'board').find('p').text(0)

                        self.check.removeClass('disabled');
                        self.waiting();
                    });
                },
                checkUp() {

                    let { check, eventlog, start } = self;
                    let { request } = Is;

                    check.click(function (e) {
                        self.waiting();
                        let data = {
                            url: `${URLEND.base}data/transfer`,
                            process: "CheckProcess",
                            code: self.selectedkey
                        };


                        request(data, function (target) {

                            let { data } = target;


                            if (data.length === 0) {
                                self.waiting();
                                return false;
                            }

                            eventlog.empty();

                            $.map(data, function (items, number) {

                                let labels = 'CheckUp'

                                eventlog.prepend(`<li class="list-group-item d-flex  align-items-center"><span class="col-8">${number + 1} : ${items['tablename']}</span><span  class="col-3">${labels}</span><span>${items.transfer.length || 0}</span></li>`)
                            })

                            self.start.removeClass('disabled');
                            self.waiting();


                        });

                    })
                },
                startUp() {

                    let { start, eventlog, board } = self;
                    let { request } = Is;

                    start.click(function (e) {
                        self.waiting();
                        let data = {
                            url: `${URLEND.base}data/transfer`,
                            process: "StartProcess",
                            code: self.selectedkey
                        };

                        request(data, function (target) {
                          
                            console.log(target);
                            let { data } = target;

                            let index = data.find(x => x.tablename === self.selectedkey)

                            if (index) {

                                board.child("succeed", 'board').find('p').text(index.report.sum("succeed"))
                                board.child("error", 'board').find('p').text(index.report.sum("errors"))

                            }

                            eventlog.empty();

                            $.map(data, function (items, number) {

                                let labels = 'Insert'

                                eventlog.prepend(`<li class="list-group-item d-flex  align-items-center px-0"><span class="col-5">${number + 1} : ${items['tablename']}</span><span  class="col-2">${labels}</span><span class="col-5 text-right">succeed : ${items.report.sum("succeed") || 0}, errors : ${items.report.sum("errors") || 0}</span></li>`)
                            })
                          
                            self.waiting();


                          
                        });

                       
                    })

                },
                waiting() {
                    self.wait.toggleClass('hide');
                }
            }


            return new transfer(obj)
        };


    </script>

    <script type="text/javascript">

        new transfer.transferController({
            task: $('#task-list'),
            board: $('#board-report'),
            eventlog: $('#eventlog'),
            check: $('[data-check="true"]'),
            start: $('[data-start="true"]')
        })
   
    </script>
</template>

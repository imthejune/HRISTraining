<%@ Page Title="" Language="VB" MasterPageFile="~/setting/setting.master" AutoEventWireup="false" CodeFile="WebTransfer.aspx.vb" Inherits="Form_Setting_WebTransfer" %>

<asp:Content ID="content3" ContentPlaceHolderID="ContentHead" runat="server">
    <style type="text/css">
        .tn-list_left.list-group .list-group-item {
            margin: .5rem;
            border: none;
            cursor: pointer;
            transition: all ease 3ms;
            color: #a7a7a7;
        }

            .tn-list_left.list-group .list-group-item span, label {
                cursor: pointer;
            }

        .tn-list_left.list-group > li > .chk {
            width: 10px;
            height: 10px;
            background: #e1e1e1;
            border-radius: 50%;
        }

        .tn-list_left.list-group > li.selected > .chk {
            background: #a7a7a7;
            color: #a7a7a7;
        }

        .tn-list_left.list-group .list-group-item.active {
            background: #f5f5f5;
            color: #a7a7a7;
            border-radius: 10px;
        }

        .tn-list_left.list-group .list-group-item:hover {
            background: #f5f5f5;
            border-radius: 10px;
        }

        .wp-ring {
            justify-content: center;
            align-items: center;
            width: 100%;
            height: 100%;
            display: flex;
            position: absolute;
            top: 0;
        }

        .wp-ringer {
            position: absolute;
            top: 0;
            right: 0;
            left: 0;
            bottom: 0;
            z-index: 1001;
        }

            .wp-ringer.hide {
                display: none;
            }

            .wp-ringer.active {
                display: block;
            }

            .wp-ringer .wp-ringer_load {
                background: #fff;
                opacity: 0.5;
                width: 100%;
                height: 100%;
            }

        .wp-ring div {
            box-sizing: border-box;
            display: block;
            position: absolute;
            width: 64px;
            height: 64px;
            margin: 8px;
            border: 8px solid #dbdbdb;
            border-radius: 50%;
            animation: wp-ring 1.2s cubic-bezier(0.5, 0, 0.5, 1) infinite;
            border-color: #dbdbdb transparent transparent transparent;
        }

            .wp-ring div:nth-child(1) {
                animation-delay: -0.45s;
            }

            .wp-ring div:nth-child(2) {
                animation-delay: -0.3s;
            }

            .wp-ring div:nth-child(3) {
                animation-delay: -0.15s;
            }

        @keyframes wp-ring {
            0% {
                transform: rotate(0deg);
            }

            100% {
                transform: rotate(360deg);
            }
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="Server">

    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
        </AjaxSettings>
    </telerik:RadAjaxManager>


    <div class="row">

        <div class="col-md-3 p-3 ">

            <div class="card border-0">
                <div class="card-body pt-2">
                    <div class="card-header  bg-transparent mb-2">
                        Installer 
                    </div>

                    <%--  <ul class="list-group list-group-flush">
                        <li class="list-group-item">Check Databaese</li>
                    </ul>--%>
                    <div class="tn-list_left list-group list-group-flush mx-3" id="list-tab" role="tablist">
                        <a class="list-group-item border-0 list-group-item-action " id="list-table-list" data-toggle="list" href="#list-table" data-pages="table" role="tab" aria-controls="table">Create Data Table</a>
                        <a class="list-group-item border-0 list-group-item-action " id="list-transfer-list" data-toggle="list" href="#list-transfer" data-pages="transfer" role="tab" aria-controls="transfer">Transfer</a>
                        <a class="list-group-item border-0 list-group-item-action  " id="list-lang-list" data-toggle="list" href="#list-lang" data-pages="lang" role="tab" aria-controls="lang">Language</a>
                        <a class="list-group-item border-0 list-group-item-action active " id="list-config-list" data-toggle="list" href="#list-config" data-pages="config" role="tab" aria-controls="config">Config</a>
                    </div>
                </div>

            </div>

        </div>
        <div class="col-md-9 p-3 ">
            <div class="tab-content" id="nav-tabContent">
                <div class="tab-pane fade " id="list-table" role="tabpanel" aria-labelledby="list-home-list">...</div>
                <div class="tab-pane fade " id="list-transfer" role="tabpanel" aria-labelledby="list-transfer-list">...</div>
              <%--  <div class="tab-pane fade " id="list-lang" role="tabpanel" aria-labelledby="list-lang-list">...</div>--%>
                <div class="tab-pane fade   show active " id="list-config" role="tabpanel" aria-labelledby="list-config-list">...</div>
            </div>
        </div>

    </div>
    <div class="wp-ringer hide">
        <div class="wp-ringer_load"></div>
        <div class="wp-ring">
            <div></div>
            <div></div>
            <div></div>
            <div>
            </div>
        </div>
    </div>




</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentScript" runat="server">

    <script type="text/javascript">

        window.URLEND = {
            base: '<%= ResolveUrl("~/")%>',
            component: '<%= ResolveUrl("~/setting/components/") %>'
        }

        if (!window.transfer) {
            window.transfer = {};
        }

        $(document).ready(function () {

            //shown.bs.tab

            let list = document.querySelectorAll('a[data-toggle="list"].active')[0]


            $('a[data-toggle="list"]').on('shown.bs.tab', function (e) {
                render(e.target);

            })

            var render = function (target) {

                let id = target.getAttribute('href');

                $(`${id}`).empty();
                let template = new WPtemplate({
                    url: `${URLEND.component}${target.getAttribute('data-pages')}.component.aspx`,
                    render: $(`${id}`),
                    uuid: Is.uuid(),
                    content: ['content-table']
                })

                template.modal(function (e) { })

            }

            render(list)

        });


    </script>

</asp:Content>


(function($){
//checkall none
$.fn.checkall=function(){this.attr("checked",true)};$.fn.checknone=function(){this.attr("checked",false)};

//footerButtom ให้ footer อยู่ด้านล่าง
$.fn.footerButtom=function(){
var g1 = $("#DataGrid1");if (g1.length>0){return ""}
var g2 = $("#Datagrid2");if (g2.length>0){return ""}
var g3 = $("#GridView1");if (g3.length>0){return ""}
var g4 = $("#GridView2");if (g4.length>0){return ""}
var f=this;
var t=$(window).height()-$(f).height()-10;
var l=($(window).width()-$(f).width())/2;
$(f).css({'position':'absolute','left':0,'top':t});
}

//focusLast ให้ cursor ไปที่ข้างท้ายของข้อความ
$.fn.focusLast=function(){ 
var o=this.get(0);
if(o.createTextRange){
var r=o.createTextRange();
r.collapse(false);
r.select();
}else if(o.setSelectionRange){o.focus()}}



//jquery.json-2.2.min.js
$.toJSON=function(o)
{if(typeof(JSON)=='object'&&JSON.stringify)return JSON.stringify(o);var type=typeof(o);if(o===null)return"null";if(type=="undefined")return undefined;if(type=="number"||type=="boolean")return o+"";if(type=="string")return $.quoteString(o);if(type=='object'){if(typeof o.toJSON=="function")return $.toJSON(o.toJSON());if(o.constructor===Date){var month=o.getUTCMonth()+1;if(month<10)month='0'+month;var day=o.getUTCDate();if(day<10)day='0'+day;var year=o.getUTCFullYear();var hours=o.getUTCHours();if(hours<10)hours='0'+hours;var minutes=o.getUTCMinutes();if(minutes<10)minutes='0'+minutes;var seconds=o.getUTCSeconds();if(seconds<10)seconds='0'+seconds;var milli=o.getUTCMilliseconds();if(milli<100)milli='0'+milli;if(milli<10)milli='0'+milli;return'"'+year+'-'+month+'-'+day+'T'+
hours+':'+minutes+':'+seconds+'.'+milli+'Z"';}if(o.constructor===Array){var ret=[];for(var i=0;i<o.length;i++)ret.push($.toJSON(o[i])||"null");return"["+ret.join(",")+"]";}var pairs=[];for(var k in o){var name;var type=typeof k;if(type=="number")name='"'+k+'"';else if(type=="string")name=$.quoteString(k);else continue;if(typeof o[k]=="function")continue;var val=$.toJSON(o[k]);pairs.push(name+":"+val);}return"{"+pairs.join(", ")+"}";}};$.evalJSON=function(src){if(typeof(JSON)=='object'&&JSON.parse)return JSON.parse(src);return eval("("+src+")");};$.secureEvalJSON=function(src){if(typeof(JSON)=='object'&&JSON.parse)return JSON.parse(src);var filtered=src;filtered=filtered.replace(/\\["\\\/bfnrtu]/g,'@');filtered=filtered.replace(/"[^"\\\n\r]*"|true|false|null|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?/g,']');filtered=filtered.replace(/(?:^|:|,)(?:\s*\[)+/g,'');if(/^[\],:{}\s]*$/.test(filtered))
return eval("("+src+")");else throw new SyntaxError("Error parsing JSON, source is not valid.");};$.quoteString=function(string){if(string.match(_escapeable)){return'"'+string.replace(_escapeable,function(a){var c=_meta[a];if(typeof c==='string')return c;c=a.charCodeAt();return'\\u00'+Math.floor(c/16).toString(16)+(c%16).toString(16);})+'"';}return'"'+string+'"';};var _escapeable=/["\\\x00-\x1f\x7f-\x9f]/g;var _meta={'\b':'\\b','\t':'\\t','\n':'\\n','\f':'\\f','\r':'\\r','"':'\\"','\\':'\\\\'};

//blockui2.36
$.fn._fadeIn=$.fn.fadeIn;var noOp=function(){};var mode=document.documentMode||0;var setExpr=$.browser.msie&&($.browser.version<8&&!mode||mode<8);var ie6=$.browser.msie&&/MSIE 6.0/.test(navigator.userAgent)&&!mode;$.blockUI=function(opts){install(window,opts)};$.unblockUI=function(opts){remove(window,opts)};$.growlUI=function(title,message,timeout,onClose){var $m=$('<div class="growlUI"></div>');if(title)$m.append("<h1>"+title+"</h1>");if(message)$m.append("<h2>"+message+"</h2>");if(timeout==
undefined)timeout=3E3;$.blockUI({message:$m,fadeIn:700,fadeOut:1E3,centerY:false,timeout:timeout,showOverlay:false,onUnblock:onClose,css:$.blockUI.defaults.growlCSS})};$.fn.block=function(opts){return this.unblock({fadeOut:0}).each(function(){if($.css(this,"position")=="static")this.style.position="relative";if($.browser.msie)this.style.zoom=1;install(this,opts)})};$.fn.unblock=function(opts){return this.each(function(){remove(this,opts)})};$.blockUI.version=2.35;$.blockUI.defaults={message:"<h1>Please wait...</h1>",
title:null,draggable:true,theme:false,css:{padding:0,margin:0,width:"30%",top:"40%",left:"35%",textAlign:"center",color:"#000",border:"3px solid #aaa",backgroundColor:"#fff",cursor:"wait"},themedCSS:{width:"30%",top:"40%",left:"35%"},overlayCSS:{backgroundColor:"#000",opacity:0.6,cursor:"wait"},growlCSS:{width:"350px",top:"10px",left:"",right:"10px",border:"none",padding:"5px",opacity:0.6,cursor:"default",color:"#fff",backgroundColor:"#000","-webkit-border-radius":"10px","-moz-border-radius":"10px",
"border-radius":"10px"},iframeSrc:/^https/i.test(window.location.href||"")?"javascript:false":"about:blank",forceIframe:false,baseZ:1E3,centerX:true,centerY:true,allowBodyStretch:true,bindEvents:true,constrainTabKey:true,fadeIn:200,fadeOut:400,timeout:0,showOverlay:true,focusInput:true,applyPlatformOpacityRules:true,onBlock:null,onUnblock:null,quirksmodeOffsetHack:4,blockMsgClass:"blockMsg"};var pageBlock=null;var pageBlockEls=[];function install(el,opts){var full=el==window;var msg=opts&&opts.message!==
undefined?opts.message:undefined;opts=$.extend({},$.blockUI.defaults,opts||{});opts.overlayCSS=$.extend({},$.blockUI.defaults.overlayCSS,opts.overlayCSS||{});var css=$.extend({},$.blockUI.defaults.css,opts.css||{});var themedCSS=$.extend({},$.blockUI.defaults.themedCSS,opts.themedCSS||{});msg=msg===undefined?opts.message:msg;if(full&&pageBlock)remove(window,{fadeOut:0});if(msg&&typeof msg!="string"&&(msg.parentNode||msg.jquery)){var node=msg.jquery?msg[0]:msg;var data={};$(el).data("blockUI.history",
data);data.el=node;data.parent=node.parentNode;data.display=node.style.display;data.position=node.style.position;if(data.parent)data.parent.removeChild(node)}var z=opts.baseZ;var lyr1=$.browser.msie||opts.forceIframe?$('<iframe class="blockUI" style="z-index:'+z++ +';display:none;border:none;margin:0;padding:0;position:absolute;width:100%;height:100%;top:0;left:0" src="'+opts.iframeSrc+'"></iframe>'):$('<div class="blockUI" style="display:none"></div>');var lyr2=$('<div class="blockUI blockOverlay" style="z-index:'+
z++ +';display:none;border:none;margin:0;padding:0;width:100%;height:100%;top:0;left:0"></div>');var lyr3,s;if(opts.theme&&full)s='<div class="blockUI '+opts.blockMsgClass+' blockPage ui-dialog ui-widget ui-corner-all" style="z-index:'+z+';display:none;position:fixed">'+'<div class="ui-widget-header ui-dialog-titlebar ui-corner-all blockTitle">'+(opts.title||"&nbsp;")+"</div>"+'<div class="ui-widget-content ui-dialog-content"></div>'+"</div>";else if(opts.theme)s='<div class="blockUI '+opts.blockMsgClass+
' blockElement ui-dialog ui-widget ui-corner-all" style="z-index:'+z+';display:none;position:absolute">'+'<div class="ui-widget-header ui-dialog-titlebar ui-corner-all blockTitle">'+(opts.title||"&nbsp;")+"</div>"+'<div class="ui-widget-content ui-dialog-content"></div>'+"</div>";else if(full)s='<div class="blockUI '+opts.blockMsgClass+' blockPage" style="z-index:'+z+';display:none;position:fixed"></div>';else s='<div class="blockUI '+opts.blockMsgClass+' blockElement" style="z-index:'+z+';display:none;position:absolute"></div>';
lyr3=$(s);if(msg)if(opts.theme){lyr3.css(themedCSS);lyr3.addClass("ui-widget-content")}else lyr3.css(css);if(!opts.applyPlatformOpacityRules||!($.browser.mozilla&&/Linux/.test(navigator.platform)))lyr2.css(opts.overlayCSS);lyr2.css("position",full?"fixed":"absolute");if($.browser.msie||opts.forceIframe)lyr1.css("opacity",0);var layers=[lyr1,lyr2,lyr3],$par=full?$("body"):$(el);$.each(layers,function(){this.appendTo($par)});if(opts.theme&&opts.draggable&&$.fn.draggable)lyr3.draggable({handle:".ui-dialog-titlebar",
cancel:"li"});var expr=setExpr&&(!$.boxModel||$("object,embed",full?null:el).length>0);if(ie6||expr){if(full&&opts.allowBodyStretch&&$.boxModel)$("html,body").css("height","100%");if((ie6||!$.boxModel)&&!full){var t=sz(el,"borderTopWidth"),l=sz(el,"borderLeftWidth");var fixT=t?"(0 - "+t+")":0;var fixL=l?"(0 - "+l+")":0}$.each([lyr1,lyr2,lyr3],function(i,o){var s=o[0].style;s.position="absolute";if(i<2){full?s.setExpression("height","Math.max(document.body.scrollHeight,document.body.offsetHeight)-(jQuery.boxModel?0:"+
opts.quirksmodeOffsetHack+')+"px"'):s.setExpression("height",'this.parentNode.offsetHeight+"px"');full?s.setExpression("width",'$(document).width()+"px"'):s.setExpression("width",'$(window).width() + "px"');if(fixL)s.setExpression("left",fixL);if(fixT)s.setExpression("top",fixT)}else if(opts.centerY){if(full){s.setExpression("top",'(document.documentElement.clientHeight||document.body.clientHeight)/2-(this.offsetHeight/2)+(blah=document.documentElement.scrollTop?document.documentElement.scrollTop:document.body.scrollTop)+"px"');
s.setExpression("left",'(document.documentElement.clientWidth || document.body.clientWidth)/2-(this.offsetWidth/2)+(blah=document.documentElement.scrollLeft?document.documentElement.scrollLeft:document.body.scrollLeft)+"px"')}s.marginTop=0}else if(!opts.centerY&&full){var top=opts.css&&opts.css.top?parseInt(opts.css.top):0;var expression="((document.documentElement.scrollTop?document.documentElement.scrollTop:document.body.scrollTop)+"+top+')+"px"';s.setExpression("top",expression)}})}if(msg){if(opts.theme)lyr3.find(".ui-widget-content").append(msg);
else lyr3.append(msg);if(msg.jquery||msg.nodeType)$(msg).show()}if(($.browser.msie||opts.forceIframe)&&opts.showOverlay)lyr1.show();if(opts.fadeIn){var cb=opts.onBlock?opts.onBlock:noOp;var cb1=opts.showOverlay&&!msg?cb:noOp;var cb2=msg?cb:noOp;if(opts.showOverlay)lyr2._fadeIn(opts.fadeIn,cb1);if(msg)lyr3._fadeIn(opts.fadeIn,cb2)}else{if(opts.showOverlay)lyr2.show();if(msg)lyr3.show();if(opts.onBlock)opts.onBlock()}bind(1,el,opts);if(full){pageBlock=lyr3[0];pageBlockEls=$(":input:enabled:visible",
pageBlock);if(opts.focusInput)setTimeout(focus,20)}else center(lyr3[0],opts.centerX,opts.centerY);if(opts.timeout){var to=setTimeout(function(){full?$.unblockUI(opts):$(el).unblock(opts)},opts.timeout);$(el).data("blockUI.timeout",to)}}function remove(el,opts){var full=el==window;var $el=$(el);var data=$el.data("blockUI.history");var to=$el.data("blockUI.timeout");if(to){clearTimeout(to);$el.removeData("blockUI.timeout")}opts=$.extend({},$.blockUI.defaults,opts||{});bind(0,el,opts);var els;if(full)els=
$("body").children().filter(".blockUI").add("body > .blockUI");else els=$(".blockUI",el);if(full)pageBlock=pageBlockEls=null;if(opts.fadeOut){els.fadeOut(opts.fadeOut);setTimeout(function(){reset(els,data,opts,el)},opts.fadeOut)}else reset(els,data,opts,el)}function reset(els,data,opts,el){els.each(function(i,o){if(this.parentNode)this.parentNode.removeChild(this)});if(data&&data.el){data.el.style.display=data.display;data.el.style.position=data.position;if(data.parent)data.parent.appendChild(data.el);
$(el).removeData("blockUI.history")}if(typeof opts.onUnblock=="function")opts.onUnblock(el,opts)}function bind(b,el,opts){var full=el==window,$el=$(el);if(!b&&(full&&!pageBlock||!full&&!$el.data("blockUI.isBlocked")))return;if(!full)$el.data("blockUI.isBlocked",b);if(!opts.bindEvents||b&&!opts.showOverlay)return;var events="mousedown mouseup keydown keypress";b?$(document).bind(events,opts,handler):$(document).unbind(events,handler)}function handler(e){if(e.keyCode&&e.keyCode==9)if(pageBlock&&e.data.constrainTabKey){var els=
pageBlockEls;var fwd=!e.shiftKey&&e.target===els[els.length-1];var back=e.shiftKey&&e.target===els[0];if(fwd||back){setTimeout(function(){focus(back)},10);return false}}var opts=e.data;if($(e.target).parents("div."+opts.blockMsgClass).length>0)return true;return $(e.target).parents().children().filter("div.blockUI").length==0}function focus(back){if(!pageBlockEls)return;var e=pageBlockEls[back===true?pageBlockEls.length-1:0];if(e)e.focus()}function center(el,x,y){var p=el.parentNode,s=el.style;var l=
(p.offsetWidth-el.offsetWidth)/2-sz(p,"borderLeftWidth");var t=(p.offsetHeight-el.offsetHeight)/2-sz(p,"borderTopWidth");if(x)s.left=l>0?l+"px":"0";if(y)s.top=t>0?t+"px":"0"}function sz(el,p){return parseInt($.css(el,p))||0}

/*jquery.allplugin.js ใช้กับหน้าที่มีตัวเลือก การค้นหา เช่นหน้าบันทึกใบลา บันทึกโอที อนุมัติ ทั้งหลาย ฯลฯ
require jquery.json-2.2.min.js,blockui2.36*/

var find=null;
$.searchPopup=function(isBlock){
	//insertBefore($("#dFoot"))}
	if(find==null){find=$('<div id="btor" style="display:none;cursor:default;text-align:left;"></div>').insertAfter($("div[class^=ui-h]:first"))}
	else{
		if(isBlock==true){$.blockUI({message:find,css:{width:'60%',left:'20%'}})}
		return false;
	}
	if(!isBlock){find.show()}
	var url="../ajaxSearchPerson.aspx?key=";
	if($.browser.msie && parseInt($.browser.version)==8){
		url+=readCookie("Key");
	}else{
		url+=Math.random();
		//url+="&_=" + String((new Date()).getTime()).replace(/\D/gi, '');
	}
//	if($.browser.msie && parseInt($.browser.version)!=8){
//		url+=Math.random();
//	}
	url+=" #Taadition";
	find.html("<img src='../images/indicator.gif' />");
	$.ajaxSetup({ cache: false });//cache disable
	find.load(url,function(response,s,xhr){
		if (s=="error"){
			find.html("Error: "+xhr.status+" "+xhr.statusText);
		}else{
			if($.browser.msie!=true && isBlock!=true){
				var w=($(window).width()-$("#Taadition",find).width())/2;
				if(w>0){$(find).css("marginLeft",w+"px")}
			}
			if(window.location.href.toLowerCase().indexOf('rpthistoryleave')!=-1){
				$("#divCompanyID",find).show()
			}else{$("#divCompanyID",find).remove()}
			var rdo = $(":radio[name=Addition]",find);
			var code=readCookie("Code");
			if(code!=''){//auto insert person code MO MFEC 2012-03-11
				$("#TxtPersonCodeF",find).val(code);
				rdo.val(["Rdo2"]);
			}			
			$("#TxtPersonCodeF",find).focus(function(){
				 if (rdo.filter(":checked").val()!="Rdo2"){rdo.val(["Rdo2"])}
			});
			$("#TxtPersonName",find).focus(function(){
				if (rdo.filter(":checked").val()!="Rdo4"){rdo.val(["Rdo4"])}
			});
			$("select",find).focus(function(){
				if(this.id!="DocNo"){
					if (rdo.filter(":checked").val()!="Rdo3"){rdo.val(["Rdo3"])}
				}
			});
			$("#Rdo2",find).click(function(e){$("#TxtPersonCodeF").select()});
			$("#Rdo4",find).click(function(e){$("#TxtPersonName").select()});
			$("#RdoDocno",find).click(function(e){$("#TxtPersonName").select()});
	 
			if(isBlock==true){$.blockUI({message:find,css:{width:'60%',left:'20%'}})}
			$("#Rdo1",find).focus();
			$("#BttCancel",find).click(function(e){
				if(isBlock==true){find.hide();$.unblockUI()}else{window.history.back()}
				return false;
			});
			$("#Bttseach",find).click(function(e) {
				var data={};data["Rdo"]=find.find("input:radio:checked").val();
				var rows=find.find("select").each(function(){
					var drp=$(this);
					if(drp.find("option:selected").val()){data[drp.attr("id")]=drp.find("option:selected").val()}
					else{data[drp.attr("id")]=""}
				});
				data["PersonCode"]=find.find("#TxtPersonCodeF").val();
				data["PersonName"]=find.find("#TxtPersonName").val();
				if(find.find("#DocNo").length>=1){data["DocNo"]=find.find("#DocNo").val()}
				else{data["DocNo"]=""}
				var json=$.toJSON(data);
				$.ajax({
					type:"POST",contentType:"application/json; charset=utf-8",
					dataType:"json",url:"../ajaxSearchPerson.aspx/GetPerson",
					data:$.toJSON(data),
					error:function(xhr,status,error){alert(eval("("+xhr.responseText+")").Message)},
					success:function(xml){
						if(xml.d=="0"){if(ckLang=='E'){alert('Data not found.')}else{alert('ไม่พบข้อมูล')}}
						else{__doPostBack('Bttseach',xml.d)}
					}
				});
				return false;
			});//end Bttseach.click
		}//end else
	});//end find .load
}; //end searchPopup



//mask1.3 http://digitalbush.com/projects/masked-input-plugin/
/*mask1.2.2
var pasteEventName=($.browser.msie?"paste":"input")+".mask",iPhone=window.orientation!=undefined;$.mask={definitions:{"9":"[0-9]",a:"[A-Za-z]","*":"[A-Za-z0-9]"}};
$.fn.extend({caret:function(g,f){if(this.length!=0)if(typeof g=="number"){f=typeof f=="number"?f:g;return this.each(function(){if(this.setSelectionRange){this.focus();this.setSelectionRange(g,f)}else if(this.createTextRange){var d=this.createTextRange();d.collapse(true);d.moveEnd("character",f);d.moveStart("character",g);d.select()}})}else{if(this[0].setSelectionRange){g=this[0].selectionStart;f=this[0].selectionEnd}else if(document.selection&&document.selection.createRange){var n=document.selection.createRange();
g=0-n.duplicate().moveStart("character",-1E5);f=g+n.text.length}return{begin:g,end:f}}},unmask:function(){return this.trigger("unmask")},mask:function(g,f){if(!g&&this.length>0){var n=$(this[0]),d=n.data("tests");return $.map(n.data("buffer"),function(k,m){return d[m]?k:null}).join("")}f=$.extend({placeholder:"_",completed:null},f);var u=$.mask.definitions;d=[];var o=g.length,r=null,j=g.length;$.each(g.split(""),function(k,m){if(m=="?"){j--;o=k}else if(u[m]){d.push(RegExp(u[m]));if(r==null)r=d.length-
1}else d.push(null)});return this.each(function(){function k(a){for(;++a<=j&&!d[a];);return a}function m(a){var b=$(this).caret();a=a.keyCode;s=a<16||a>16&&a<32||a>32&&a<41;if(b.begin-b.end!=0&&(!s||a==8||a==46))w(b.begin,b.end);if(a==8||a==46||iPhone&&a==127){for(b=b.begin+(a==46?0:-1);!d[b]&&--b>=0;);for(a=b;a<j;a++)if(d[a]){i[a]=f.placeholder;var c=k(a);if(c<j&&d[a].test(i[c]))i[a]=i[c];else break}t();e.caret(Math.max(r,b));return false}else if(a==27){e.val(v);e.caret(0,p());return false}}function x(a){if(s){s=
false;return a.keyCode==8?false:null}a=a||window.event;var b=a.charCode||a.keyCode||a.which,c=$(this).caret();if(a.ctrlKey||a.altKey||a.metaKey)return true;else if(b>=32&&b<=125||b>186){a=k(c.begin-1);if(a<j){b=String.fromCharCode(b);if(d[a].test(b)){c=a;for(var h=f.placeholder;c<j;c++)if(d[c]){var l=k(c),q=i[c];i[c]=h;if(l<j&&d[l].test(q))h=q;else break}i[a]=b;t();a=k(a);$(this).caret(a);f.completed&&a==j&&f.completed.call(e)}}}return false}function w(a,b){for(var c=a;c<b&&c<j;c++)if(d[c])i[c]=f.placeholder}
function t(){return e.val(i.join("")).val()}function p(a){for(var b=e.val(),c=-1,h=0,l=0;h<j;h++)if(d[h]){for(i[h]=f.placeholder;l++<b.length;){var q=b.charAt(l-1);if(d[h].test(q)){i[h]=q;c=h;break}}if(l>b.length)break}else if(i[h]==b[l]&&h!=o){l++;c=h}if(!a&&c+1<o){e.val("");w(0,j)}else if(a||c+1>=o){t();a||e.val(e.val().substring(0,c+1))}return o?h:r}var e=$(this),i=$.map(g.split(""),function(a){if(a!="?")return u[a]?f.placeholder:a}),s=false,v=e.val();e.data("buffer",i).data("tests",d);e.attr("readonly")||
e.one("unmask",function(){e.unbind(".mask").removeData("buffer").removeData("tests")}).bind("focus.mask",function(){v=e.val();var a=p();t();setTimeout(function(){a==g.length?e.caret(0,a):e.caret(a)},0)}).bind("blur.mask",function(){p();e.val()!=v&&e.change()}).bind("keydown.mask",m).bind("keypress.mask",x).bind(pasteEventName,function(){setTimeout(function(){e.caret(p(true))},0)});p()})}});
*/


//mask1.3
var pasteEventName = ($.browser.msie ? 'paste' : 'input') + ".mask";
var iPhone = (window.orientation != undefined);

$.mask = {
    //Predefined character definitions
    definitions: {
        '9': "[0-9]",
        'a': "[A-Za-z]",
        '*': "[A-Za-z0-9]"
    },
    dataName: "rawMaskFn"
};
$.fn.extend({
    //Helper Function for Caret positioning
    caret: function(begin, end) {
        if (this.length == 0) return;
        if (typeof begin == 'number') {
            end = (typeof end == 'number') ? end : begin;
            return this.each(function() {
                if (this.setSelectionRange) {
                    this.setSelectionRange(begin, end);
                } else if (this.createTextRange) {
                    var range = this.createTextRange();
                    range.collapse(true);
                    range.moveEnd('character', end);
                    range.moveStart('character', begin);
                    range.select();
                }
            });
        } else {
            if (this[0].setSelectionRange) {
                begin = this[0].selectionStart;
                end = this[0].selectionEnd;
            } else if (document.selection && document.selection.createRange) {
                var range = document.selection.createRange();
                begin = 0 - range.duplicate().moveStart('character', -100000);
                end = begin + range.text.length;
            }
            return { begin: begin, end: end };
        }
    },
    unmask: function() { return this.trigger("unmask"); },
    mask: function(mask, settings) {
        if (!mask && this.length > 0) {
            var input = $(this[0]);
            return input.data($.mask.dataName)();
        }
        settings = $.extend({
            placeholder: "_",
            completed: null
        }, settings);

        var defs = $.mask.definitions;
        var tests = [];
        var partialPosition = mask.length;
        var firstNonMaskPos = null;
        var len = mask.length;

        $.each(mask.split(""), function(i, c) {
            if (c == '?') {
                len--;
                partialPosition = i;
            } else if (defs[c]) {
                tests.push(new RegExp(defs[c]));
                if (firstNonMaskPos == null)
                    firstNonMaskPos = tests.length - 1;
            } else {
                tests.push(null);
            }
        });

        return this.trigger("unmask").each(function() {
            var input = $(this);
            var buffer = $.map(mask.split(""), function(c, i) { if (c != '?') return defs[c] ? settings.placeholder : c });
            var focusText = input.val();

            function seekNext(pos) {
                while (++pos <= len && !tests[pos]);
                return pos;
            };
            function seekPrev(pos) {
                while (--pos >= 0 && !tests[pos]);
                return pos;
            };

            function shiftL(begin, end) {
                if (begin < 0)
                    return;
                for (var i = begin, j = seekNext(end); i < len; i++) {
                    if (tests[i]) {
                        if (j < len && tests[i].test(buffer[j])) {
                            buffer[i] = buffer[j];
                            buffer[j] = settings.placeholder;
                        } else
                            break;
                        j = seekNext(j);
                    }
                }
                writeBuffer();
                input.caret(Math.max(firstNonMaskPos, begin));
            };

            function shiftR(pos) {
                for (var i = pos, c = settings.placeholder; i < len; i++) {
                    if (tests[i]) {
                        var j = seekNext(i);
                        var t = buffer[i];
                        buffer[i] = c;
                        if (j < len && tests[j].test(t))
                            c = t;
                        else
                            break;
                    }
                }
            };

            function keydownEvent(e) {
                var k = e.which;

                //backspace, delete, and escape get special treatment
                if (k == 8 || k == 46 || (iPhone && k == 127)) {
                    var pos = input.caret(),
begin = pos.begin,
end = pos.end;

                    if (end - begin == 0) {
                        begin = k != 46 ? seekPrev(begin) : (end = seekNext(begin - 1));
                        end = k == 46 ? seekNext(end) : end;
                    }
                    clearBuffer(begin, end);
                    shiftL(begin, end - 1);

                    return false;
                } else if (k == 27) {//escape
                    input.val(focusText);
                    input.caret(0, checkVal());
                    return false;
                }
            };

            function keypressEvent(e) {
                var k = e.which,
pos = input.caret();
                if (e.ctrlKey || e.altKey || e.metaKey || k < 32) {//Ignore
                    return true;
                } else if (k) {
                    if (pos.end - pos.begin != 0) {
                        clearBuffer(pos.begin, pos.end);
                        shiftL(pos.begin, pos.end - 1);
                    }

                    var p = seekNext(pos.begin - 1);
                    if (p < len) {
                        var c = String.fromCharCode(k);
                        if (tests[p].test(c)) {
                            shiftR(p);
                            buffer[p] = c;
                            writeBuffer();
                            var next = seekNext(p);
                            input.caret(next);
                            if (settings.completed && next >= len)
                                settings.completed.call(input);
                        }
                    }
                    return false;
                }
            };

            function clearBuffer(start, end) {
                for (var i = start; i < end && i < len; i++) {
                    if (tests[i])
                        buffer[i] = settings.placeholder;
                }
            };

            function writeBuffer() { return input.val(buffer.join('')).val(); };

            function checkVal(allow) {
                //try to place characters where they belong
                var test = input.val();
                var lastMatch = -1;
                for (var i = 0, pos = 0; i < len; i++) {
                    if (tests[i]) {
                        buffer[i] = settings.placeholder;
                        while (pos++ < test.length) {
                            var c = test.charAt(pos - 1);
                            if (tests[i].test(c)) {
                                buffer[i] = c;
                                lastMatch = i;
                                break;
                            }
                        }
                        if (pos > test.length)
                            break;
                    } else if (buffer[i] == test.charAt(pos) && i != partialPosition) {
                        pos++;
                        lastMatch = i;
                    }
                }
                if (!allow && lastMatch + 1 < partialPosition) {
                    input.val("");
                    clearBuffer(0, len);
                } else if (allow || lastMatch + 1 >= partialPosition) {
                    writeBuffer();
                    if (!allow) input.val(input.val().substring(0, lastMatch + 1));
                }
                return (partialPosition ? i : firstNonMaskPos);
            };

            input.data($.mask.dataName, function() {
                return $.map(buffer, function(c, i) {
                    return tests[i] && c != settings.placeholder ? c : null;
                }).join('');
            })

            if (!input.attr("readonly"))
                input
.one("unmask", function() {
    input
.unbind(".mask")
.removeData($.mask.dataName);
})
.bind("focus.mask", function() {
    focusText = input.val();
    var pos = checkVal();
    writeBuffer();
    var moveCaret = function() {
        if (pos == mask.length)
            input.caret(0, pos);
        else
            input.caret(pos);
    };
    ($.browser.msie ? moveCaret : function() { setTimeout(moveCaret, 0) })();
})
.bind("blur.mask", function() {
    checkVal();
    if (input.val() != focusText)
        input.change();
})
.bind("keydown.mask", keydownEvent)
.bind("keypress.mask", keypressEvent)
.bind(pasteEventName, function() {
    setTimeout(function() { input.caret(checkVal(true)); }, 0);
});

            checkVal(); //Perform initial check for existing values
        });
    }
});

})(jQuery);
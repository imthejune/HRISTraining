
var imgUrl = null;
//function alertCallBackFn(arg) {
//    radalert("<strong>radalert</strong> returned the following result: <h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Result");/
//}

function confirmCallBackFn(arg) {
    //radalert("<strong>ยืนยัน</strong> returned the following result: <h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Result");
    if (arg == true) {
        __doPostBack('confirm', 'ok');
    } else {
        __doPostBack('confirm', 'no');
    }

}

//function promptCallBackFn(arg) {
//   radalert("After 7.5 million years, <strong>Deep Thought</strong> answers:<h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Deep Thought");
//}

//function pageLoad() {
    //attach a handler to radion buttons to update global variable holding image url
//    var $ = $telerik.$;
 //   $('input:radio').bind('click', function () {
 //       imgUrl = $(this).val();
 //   });
//}
function readCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
    }
    if (name == 'Lang') { return 'T' }
    return '';
}


var cultureVal = readCookie("Lang");

function setDateCultureTH(ImgLv) {
    var ImgPath = '../Image/calendar.gif';
    if (ImgLv == 0) { ImgPath = 'Image/calendar.gif'; }
    else if (ImgLv == 1) { ImgPath = '../Image/calendar.gif'; }
    else if (ImgLv == 2) { ImgPath = '../../Image/calendar.gif'; }
    else if (ImgLv == 3) { ImgPath = '../../../Image/calendar.gif'; }

    if ($.datepicker == null) return;
    $.datepicker.regional['th'] = {
        changeMonth: true,
        changeYear: true,
        //defaultDate: GetFxupdateDate(FxRateDateAndUpdate.d[0].Day),
        yearOffSet: 543,
        showOn: "button",
        buttonImage: ImgPath,
        buttonImageOnly: true,
        dateFormat: 'dd/mm/yy',
        dayNames: ['อาทิตย์', 'จันทร์', 'อังคาร', 'พุธ', 'พฤหัสบดี', 'ศุกร์', 'เสาร์'],
        dayNamesMin: ['อา', 'จ', 'อ', 'พ', 'พฤ', 'ศ', 'ส'],
        monthNames: ['มกราคม', 'กุมภาพันธ์', 'มีนาคม', 'เมษายน', 'พฤษภาคม', 'มิถุนายน', 'กรกฎาคม', 'สิงหาคม', 'กันยายน', 'ตุลาคม', 'พฤศจิกายน', 'ธันวาคม'],
        monthNamesShort: ['ม.ค.', 'ก.พ.', 'มี.ค.', 'เม.ย.', 'พ.ค.', 'มิ.ย.', 'ก.ค.', 'ส.ค.', 'ก.ย.', 'ต.ค.', 'พ.ย.', 'ธ.ค.'],
        constrainInput: true,
        prevText: 'ก่อนหน้า',
        nextText: 'ถัดไป',
        yearRange: '-80:+10',
        buttonText: 'เลือก',
    };

    $.datepicker.setDefaults($.datepicker.regional['th']);
}

function setDateCultureEN(ImgLv) {
    var ImgPath = '../../Image/calendar.gif';
    if (ImgLv == 0) { ImgPath = 'Image/calendar.gif'; }
    else if (ImgLv == 1) { ImgPath = '../Image/calendar.gif'; }
    else if (ImgLv == 2) { ImgPath = '../../Image/calendar.gif'; }
    else if (ImgLv == 3) { ImgPath = '../../../Image/calendar.gif'; }

    if ($.datepicker == null) return;
    $.datepicker.regional['en'] = {
        changeMonth: true,
        changeYear: true,
        //defaultDate: GetFxupdateDate(FxRateDateAndUpdate.d[0].Day),
        yearOffSet: 0,
        showOn: "button",
        buttonImage: ImgPath,
        buttonImageOnly: true,
        dateFormat: 'dd/mm/yy',
        dayNames: ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thrusday', 'Friday', 'Saturday'],
        dayNamesMin: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'],
        monthNames: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'],
        monthNamesShort: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],
        constrainInput: true,
        prevText: 'Previous',
        nextText: 'Next',
        yearRange: '-80:+10',
        buttonText: 'Select',
    };

    $.datepicker.setDefaults($.datepicker.regional['en']);
}


$(function () {
   
    //var t = $('input:text,textarea');
    // t.first().focus();
    $('body').on('keydown', 'input:text,textarea,input:password,input:checkbox,input:radio', function (e) {
        if (e.which == 13 || e.which == 9) {   //Enter key
            if (this.id == "ctl00_ContentPlaceHolder1_txt_PersonID" ||
                this.id == "ContentPlaceHolder1_txt_PersonID" ||
                this.id.indexOf("txt_PersonID1") >= 0||
                this.id.indexOf("txt_PersonID2") >= 0)
            {
                //skip ค้นหารหัสพนักงาน
            }
            else if (this.id.indexOf("ctl00_ContentPlaceHolder1_gex") == 0)
            {
                //skip enter ใน radgrid
            }
            else {
                //                        if(this.id=="TxtDateE"){$('#BtnShow').click()}
                var t = $('input:text,textarea,input:password,input:checkbox,input:radio');
                e.preventDefault(); //ไม่สนใจ default behaviour ของ enter key
                var nextIndex = t.index(this);


                focusText(nextIndex);

            }
        }
    });
  
    function focusText(nextIndex) {

        nextIndex = nextIndex + 1;
        var t = $('input:text,textarea,input:password,input:checkbox,input:radio');

        if ($(t[nextIndex]).is(':disabled')) {
            focusText(nextIndex);
            return false;

        } 
        
        if ($(t[nextIndex]).is('[readonly]')) {
            
            focusText(nextIndex);
            return false;
            //t[nextIndex].focus()

        } //กรณีข้าม Grid Tab 

        if (t[nextIndex].name.indexOf('Grid') > 0) {
            focusText(nextIndex);
            return false;
            //t[nextIndex].focus()
        }

        

        if (t[nextIndex]) {

            t[nextIndex].focus()
        } else {
            if (nextIndex >= t.length) { return false }
            else {

            focusText(nextIndex);
        }
        }
    }


});

// ไว้ เคลียร์ค่าตอนกดปุ่ม 6 Combo เพื่อให้เข้า ItemsRequested ของแต่ละ Combo //
function MyClientBlur(sender, eventArgs) {
    // false ใช้ในกรณี Clear item ตอน แก้ไข ////
    sender.requestItems("", false);
}

function keyintdot() {
    var key = event.keyCode ? event.keyCode : event.which ? event.which : event.charCode;
    if ((key < 46 || key > 57 || key == 47) && (key != 13)) {
        event.returnValue = false;
        event.cancel = true;
        if (event.preventDefault) {
            event.preventDefault();
        }
    }
}

function Comma(Num) {
    Num += '';
    Num = Num.replace(/,/g, '');

    x = Num.split('.');
    x1 = x[0];
    x2 = x.length > 1 ? '.' + x[1] : '';
    var rgx = /(\d+)(\d{3})/;
    while (rgx.test(x1))
        x1 = x1.replace(rgx, '$1' + ',' + '$2');
    return x1 + x2;
}


//20161005 Na ทำให้ Popup เช็ครหัสพนักงานซ้ำ ปุ่ม OK อยู่ตรงกลาง
function FixCenterItem(theCenter) {
    $telerik.$('.rwPopupButton')[0].parentNode.style.paddingTop = "6px";
    $telerik.$('.rwPopupButton')[0].parentNode.style.paddingLeft = theCenter + "px";
}

function AlertMessage(message, width, height, title) {
    var oWnd = radalert(message, width, height, title);
    CenterItem('.rwDialogPopup', '.rwDialogText', '.rwPopupButton');
}

function CenterItem(parentItem, subparentItem, theItem, isRadConfirmShown) {
    var parentWidth = $telerik.$(parentItem).outerWidth();
    var subparentWidth = $telerik.$(subparentItem).outerWidth();
    var itemWidth = $telerik.$(theItem).outerWidth();

    var theCenter = parentWidth / 2 - (parentWidth - subparentWidth) - itemWidth / 2;
    if ($telerik.$(theItem).length > 0) {
        if (theCenter <= 0) {
            theCenter = 0;
        }
        else {
            if (isRadConfirmShown) theCenter -= 20;

        }
        $telerik.$(theItem)[0].parentNode.style.paddingTop = "6px";
        $telerik.$(theItem)[0].parentNode.style.paddingLeft = theCenter + "px";
    }
}
// =============== End ==========================//


$(function () {
    if ($("a.confiermDelation").length){
        $("a.confiermDelation").click(() => {
            if (!confirm("confirm deletion")) return false;
        }); 
    }

    if ($("div.alert.notification").length) {
        setTimeout(() => {
            $("div.alert.notification").fadeOut();
        }, 1000);
    }
});


//bootbox.confirm({
//    title: "Destroy row?",
//    message: "Do you want to delete",
//    buttons: {
//        cancel: {
//            label: '<i class="fa fa-times"></i> Cancel'
//        },
//        confirm: {
//            label: '<i class="fa fa-check"></i> Confirm'
//        }
//    },
//    callback: function (result) {
//        console.log('This was logged in the callback: ' + result);
//    }
//});
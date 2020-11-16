$("#select_tour").select2({
    maximumInputLength: 20 // only allow terms up to 20 characters long
});
$("#select_tour").change(function(){
    $(".form_tour").show();
})
$("#select-tour-price").change(function () {
    var tourid = $('#select-tour-price').val();
    $.ajax({
        type: "GET",
        url: "/Doan/getGia?id=" + tourid,
        data: null,
        dataType: "text",
        success: function (data) {
            var x = parseInt(data);
            x = x.toLocaleString('vi', {style : 'currency', currency : 'VND'});
            $("#price-tour-d").val(x);
        },
        error: function (req, status, error) {
            console.log(msg);
        }
    }); 
})
$("#btn_nhan_vien").click(function(){
    $(".form_nhanvien").show();
    var numberHdv = $("#in_hdv").val();
    var numberPdv = $("#in_pdv").val();
    var numberTx = $("#in_tx").val();
    $(".list-group-hdv").show();
    if(numberPdv > 0){
        $(".list-group-pdv").show();
    }
    else{
        $(".list-group-pdv").hide();
    }
    $(".list-group-tx").show();
})

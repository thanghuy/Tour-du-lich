$("#select_tour").select2({
    maximumInputLength: 20 // only allow terms up to 20 characters long
});
$("#select_tour").change(function(){
    $(".form_tour").show();
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
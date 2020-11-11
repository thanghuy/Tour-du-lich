$(document).ready(function(){

    function themDiaDiem(){
        $("#themdiadiem").on("click",function(){
            var soluong = $("#soluong").val();
            var lastnumber = $("#last-number").val();
            var dem = 0; 
            for(var i = 1 ; i <= soluong ; i++){
                dem = parseInt(i)+ parseInt(lastnumber);
                $("#listPlace").append('<hr><div class="form-group">'
                +'<label>Địa điểm '+dem+'</label>'
                +'<select class="form-control" id="idAddress-'+dem+'"class="addressTour">'
                +'<option>Chọn địa điểm - thành phố</option>'
                +'<option>Đà Lạt</option>'
                +'<option>Nha Trang</option>'
                +'<option>Đà Nẵng</option>'
                +'<option>Phan Thiết</option>'
                +'<option>Phú Quốc</option>'
                +'</select>'
                +'</div>'
                +'<div id="detailPlace'+dem+'">'
                +'</div>');
            }
            $("#last-number").val(dem);
            selectPlace();
        })
    }

    function selectPlace(){
        var arr = [];
        $("select ,.addressTour").on('change',function () {
            arr.push($(this).val());
            var id = this.id;
            var idDetailAddress = id.split("-")[1];
            if(idDetailAddress == undefined){
                idDetailAddress = "";
            }
            $("#detailPlace"+idDetailAddress).html('<div class="form-check">'
            +'<input class="form-check-input" type="checkbox" value="" id="defaultCheck1">'
            +'<label class="form-check-label" for="defaultCheck1">'
            +'Mũi né'
            +'</label>'
            +'</div>'
            +'<div class="form-check">'
            +'<input class="form-check-input" type="checkbox" value="" id="defaultCheck1">'
            +'<label class="form-check-label" for="defaultCheck1">'
            +'Đồi cát'
            +'</label>'
            +'</div>');
        })
    }
    
    themDiaDiem();
    selectPlace();
    $("#btn_khach_hang").on("click",function(){
        var numberNL = $("#nguoi_lon").val();
        var numberTE = $("#tre_em").val();
        var total = parseInt(numberNL)+parseInt(numberTE);
        $("#tong_ng_di").val(total);
        $(".form_list_customer").show();
        var a = "";
        for(var i = 1;i<=total ; i++){
           a += '<ul class="list-group list-group-flush">'
                +'<li class="list-group-item ">Khách hàng '+i+'</li>'
                +'<li class="list-group-item">'
                +'<div class="row">'
                +'  <div class="col">'
                +'    <label>Họ tên</label>'
                +'    <input type="text" class="form-control test" placeholder="Nhập họ tên" id="name'+i+'">'
                +'  </div>'
                +'  <div class="col">'
                +'    <label>Số CMND</label>'
                +'    <input type="text" class="form-control test" placeholder="Nhập số chứng minh">'
                +'  </div>'
                +'  <div class="col">'
                +'    <label>Email</label>'
                +'    <input type="text" class="form-control test" placeholder="Nhập email">'
                +'  </div>'
                +'  <div class="col">'
                +'    <label>Số điện thoại</label>'
                +'    <input type="text" class="form-control test" placeholder="Nhập số điện thoại">'
                +'  </div>'
                +'  <div class="col-3">'
                +'    <label>Ngày sinh</label>'
                +'    <div class="d-flex justify-content-end">'
                +'      <select class="form-control day-kh">'
                +'      <option value="0" selected="true">Ngày</option>'
                +'    </select>'
                +'    <select class="form-control month-kh">'
                +'      <option value="1" selected="true">Tháng</option>'
                +'    </select>'
                +'    <select class="form-control year-kh">'
                +'      <option value="1" selected="true">Năm</option>'
                +'    </select>'
                +'  </div>'
                +'</div>'
                +'  </div>'
                +'    </li>'
                +'<li class="list-group-item">'
                +' <div class="d-flex justify-content-end">Trị giá :&nbsp'
                +'  <label class="text-danger">2.399.000 VNĐ</label>'
                +'</div>'
                +'</li>'
            +'</ul>';
        }
        $("#list_customer_main").html(a);
        for(var i = 1;i <= 31;i++){
            $(".day-kh").append("<option>"+i+"</option>");
        }
        for(var i = 1;i <= 12;i++){
            $(".month-kh").append("<option>"+i+"</option>");
        }
        for(var i = new Date().getFullYear(); i > 1950; i--){
            $(".year-kh").append("<option>"+i+"</option>");
        }
        var tam = [];
        $("#btn_save_tour").click(function(){
            $(".test").each(function(){
                tam.push($(this).val());
            });
            console.log(tam);
        })
    })
    function loadBirthay(){
        for(var i = 1;i <= 31;i++){
            $(".day-nv").append("<option>"+i+"</option>");
        }
        for(var i = 1;i <= 12;i++){
            $(".month-nv").append("<option>"+i+"</option>");
        }
        for(var i = new Date().getFullYear(); i > 1950; i--){
            $(".year-nv").append("<option>"+i+"</option>");
        }
      }
      loadBirthay();
      $("#link-nv").click(function(){
        $("#link-customer").removeClass( "active");
        $("#link-cp").removeClass( "active");
        $("#link-nv").addClass("active");
        $("#list-customer").hide();
        $("#list-cp").hide();
        $("#list-nv").show();
    })
    $("#link-customer").click(function(){
        $("#link-nv").removeClass( "active");
        $("#link-cp").removeClass( "active");
        $("#link-customer").addClass("active");
        $("#list-customer").show();
        $("#list-nv").hide();
        $("#list-cp").hide();
    })
    $("#link-cp").click(function(){
        $("#link-nv").removeClass( "active");
        $("#link-customer").removeClass( "active");
        $("#link-cp").addClass("active");
        $("#list-cp").show();
        $("#list-nv").hide();
        $("#list-customer").hide();
    })
    // data table tour
    $("#tableXemGiaTour").DataTable();
    // data table doan
    $("#table-doan").DataTable();
    // data table nguoi di
    $("#table-nguoi-di").DataTable({
        "paging": false,
        "lengthChange": false,
        "searching": false,
        "ordering": true,
        "info": false,
        "autoWidth": false,
    });

    //xử lý chọn địa điểm cho tour
    var list_location = [];
    $("#select-location-tour").change(function () {
        var location = $("#select-location-tour").val();
        var list_location_giaodien = "";

        $.ajax({
            type: "GET",
            url: "/Quanlytour/GetLocation/?location=" + location,
            data: null,
            dataType: "text",
            contentType: "application/x-www-form-urlencoded; charset=UTF-8",
            success: function (data) {
                var result = $.parseJSON(data);
                console.log(result.data);
                for (var item of result.data) {
                    list_location_giaodien += '<div class="form-group check-place" id="p-' + item.diadiemId + '">'
                        + '<input class="form-check-input check-value listbox1" type="checkbox" value="' + item.diadiemId + '" id="defaultCheck' + item.diadiemId + '">'
                        + '<label class="form-check-label name-place" for="defaultCheck' + item.diadiemId + '">'
                        + item.ten
                        + '</label>'
                        + '</div>';
                }
                $("#check-main-tour-to").html(list_location_giaodien);
            },
            error: function (req, status, error) {
                console.log(msg);
            }
        });
        /*for(var i = 0; i < 3;i++){
            list_location_giaodien +='<div class="form-group check-place" id="p-'+i+'">'
            +'<input class="form-check-input check-value listbox1" type="checkbox" value="'+i+'" id="defaultCheck'+i+'">'
            +'<label class="form-check-label name-place" for="defaultCheck'+i+'">'
            +'Địa điểm '+i
            +'</label>'
          +'</div>';
        }*/
        $("#check-main-tour-to").html(list_location_giaodien);
        $("#location-add").click(function(){
            var arr = [];
            $('.listbox1:checked').each(function () {
                arr.push($(this).val());
                list_location.push($(this).val());
                $(this).prop('checked', false); 
            });
            for(var item of arr){
                $('#check-main-tour-form').append($("#p-"+item).clone());
                $('#p-'+item).remove();
            }
            $("#kq-list-place").val(list_location);
        })
        $("#location-de").click(function(){
            var arr = [];
            $('.listbox1:checked').each(function () {
                arr.push($(this).val());
            });
            for(var item of arr){
                const index = list_location.indexOf(item);
                if (index > -1) {
                    list_location.splice(index, 1);
                }
                $('#p-' + item).remove();
            }
            //$('#check-main-tour-to').append($("#p-"+item).clone());  
            $("#kq-list-place").val(list_location);
        })
    })
    
});
/*function ValidateSelectList() {
    if ($("#ToudId")[0].selectedIndex = 0) {
        $("#Tour_Id").text("ádhasd");
        return false;
    } else {
        return true;
    }
}*/
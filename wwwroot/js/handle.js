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
                +'    <input name="full-name[]" type="text" class="form-control test" placeholder="Nhập họ tên">'
                +'  </div>'
                +'  <div class="col">'
                +'    <label>Số CMND</label>'
                +'    <input name="cmnd[]" type="text" class="form-control test" placeholder="Nhập số chứng minh">'
                +'  </div>'
                +'  <div class="col">'
                +'    <label>Email</label>'
                +'    <input name="email[]" type="text" class="form-control test" placeholder="Nhập email">'
                +'  </div>'
                +'  <div class="col">'
                +'    <label>Số điện thoại</label>'
                +'    <input name="sdt[]" type="text" class="form-control test" placeholder="Nhập số điện thoại">'
                +'  </div>'
                +'  <div class="col-3">'
                +'    <label>Ngày sinh</label>'
                +'    <div class="d-flex justify-content-end">'
                +'      <select name="ngay[]" class="form-control day-kh">'
                +'      <option value="0" selected="true">Ngày</option>'
                +'    </select>'
                +'    <select name="thang[]" class="form-control month-kh">'
                +'      <option value="1" selected="true">Tháng</option>'
                +'    </select>'
                +'    <select name="nam[]" class="form-control year-kh">'
                +'      <option value="1" selected="true">Năm</option>'
                +'    </select>'
                +'  </div>'
                +'</div>'
                +'  </div>'
                +'    </li>'
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
        $("#save-kh").click(function(){
            var name = $('input[name^=full-name]').map(function(idx, elem) {
                return $(elem).val();
              });
            var cmnd = $('input[name^=cmnd]').map(function(idx, elem) {
                return $(elem).val();
              });
            var sdt = $('input[name^=sdt]').map(function(idx, elem) {
            return $(elem).val();
            });
            var email = $('input[name^=email]').map(function(idx, elem) {
                return $(elem).val();
            });
            var ngay = $('select[name^=ngay]').map(function(idx, elem) {
                return $(elem).val();
            });
            var thang = $('select[name^=thang]').map(function(idx, elem) {
                return $(elem).val();
            });
            var nam = $('select[name^=nam]').map(function(idx, elem) {
                return $(elem).val();
            });
            for(var k = 0 ; k < total ;k++){
                var ngaysinh = ngay[k] +"-"+thang[k]+"-"+nam[k];
                var list_khs = {
                    "KhTen" : name[k],
                    "KhCmnd" : cmnd[k],
                    "KhSdt" : sdt[k],
                    "KhEmail" : email[k],
                    "KhNgaysinh" : ngaysinh
                    
                };
                $.ajax({
                    type: "POST",
                    url: "/Doan/themkhachmoi",
                    data: JSON.stringify(list_khs),
                    dataType: "json",  
                    contentType: "application/json; charset=utf-8",  
                    success: function (data) {
                        var a = $("#table-nguoi-di").DataTable();
                        var b = '<a class="btn btn-primary btn-sm" href="#">'
                        +'<i class="fas fa-pencil-alt"></i> Sửa</a> <button class="btn btn-danger btn-sm delete-kh"  value="'+data.khId+'"><i class="fas fa-trash"></i></button>';
                        a.row.add([data.khId,data.khTen,data.khSdt,data.khNgaysinh,data.khEmail,data.khCmnd,b]).draw();
                    },
                    error: function (req, status, error) {
                        console.log(msg);
                    }
                }); 
            }
            $("#list_customer_main").empty();

        })
    })
    $("#add-kh-op").click(function(){
        var idkh = $("#list-op-kh").val();
        if(idkh == 0){
            alert("Mời bạn chọn khách hàng");
        }
        else{
            $.ajax({
                type: "GET",
                url: "/Doan/themkhach/?idkh="+idkh,
                data: null,
                dataType: "json",  
                contentType: "application/json; charset=utf-8",  
                success: function (data) {
                    if(data == null){
                        alert("Khách hàng này đã thêm");
                    }
                    else{
                        var a = $("#table-nguoi-di").DataTable();
                        var b = '<a class="btn btn-primary btn-sm" href="#">'
                        +'<i class="fas fa-pencil-alt"></i> Sửa</a> <button class="btn btn-danger btn-sm delete-kh" value="'+data.khId+'"><i class="fas fa-trash"></i></button>';
                        a.row.add([data.khId,data.khTen,data.khSdt,data.khNgaysinh,data.khEmail,data.khCmnd,b]).draw();
                    }
                },
                error: function (req, status, error) {
                    console.log(msg);
                }
            }); 
        }
    })
    function loadBirthay(){
        for (var i = 1; i <= 31; i++){
            if (i < 10) {
                $(".day-nv").append("<option>" + 0 + i + "</option>");
            }
            else {
                $(".day-nv").append("<option>" + i + "</option>");
            }
        }
        for (var i = 1; i <= 12; i++){
            if (i < 10) {
                $(".month-nv").append("<option>" + 0 + i + "</option>");
            }
            else {
                $(".month-nv").append("<option>" + i + "</option>");
            }
        }
        for(var i = new Date().getFullYear(); i > 1950; i--){
            $(".year-nv").append("<option>"+i+"</option>");
        }
      }
      loadBirthay();
      function checkPage(){
        const urlParams = new URLSearchParams(window.location.search);
        const myParam = urlParams.get('page');
        if(myParam == null){
            showPageDetail();
        }
        if(myParam == "nhanvien"){
            showPageNV();
        }
        if(myParam == "khachhang"){
            showPageKH();
        }
       
      }
      checkPage();
      function showPageDetail(){
        $("#link-customer").removeClass( "active");
        $("#link-nv").removeClass("active");
        $("#link-detail").addClass("active");
        $("#list-customer").hide();
        $("#list-nv").hide();
        //$("#list-detail").show();
        var url = window.location.pathname;
        window.history.replaceState('', '', url);
      }
      function showPageNV(){
        $("#link-customer").removeClass( "active");
        $("#link-detail").removeClass("active");
        $("#link-nv").addClass("active");
        $("#list-customer").hide();
        $("#list-nv").show();
        var url = window.location.pathname;
        window.history.replaceState('', '', url+"?page=nhanvien");
      }
      function showPageKH(){
        $("#link-nv").removeClass( "active");
        $("#link-detail").removeClass("active");
        $("#link-customer").addClass("active");
        $("#list-customer").show();
        $("#list-nv").hide();
        var url = window.location.pathname;
        window.history.replaceState('', '', url+"?page=khachhang");
      }
      
      $("#link-detail").click(function(){
          showPageDetail();
      });
      $("#link-nv").click(function(){
          showPageNV();
        })
        $("#link-customer").click(function(){
            showPageKH();
        })
        $("#link-cp").click(function(){
            showPageCP();
        })
    // data table tour
    $("#tableXemGiaTour").DataTable();
    // data table doan
    $("#table-doan").DataTable();
    // data table nguoi di
    var mytables = $("#table-nguoi-di").DataTable({
        "paging": true,
        "lengthChange": 5,
        "searching": true,
        "ordering": 5,
        "info": false,
    });
    $('#table-nguoi-di').on( 'click', '.delete-kh', function () {
        var idkh = $(this).val();
        $.ajax({
            type: "GET",
            url: "/Doan/xoakhachhang/?idkh="+idkh,
            data: null,
            dataType: "json",  
            contentType: "application/json; charset=utf-8",  
            success: function (data) {
                console.log(data);
            },
            error: function (req, status, error) {
                console.log(msg);
            }
        });
        mytables.row($(this).parents('tr')).remove().draw();
    } );
    //
    var tablenv = $("#table-nhan-vien").DataTable({
        "paging": true,
        "lengthChange": 5,
        "searching": true,
        "ordering": 5,
        "info": false,
    });
    $("#add-nv-op").click(function(){
        var idnv = $("#op-nv-doan").val();
        if(idnv == 0){
            alert("Mời bạn chọn nhân viên");
        }
        else{
            $.ajax({
                type: "GET",
                url: "/Doan/themnhanvien/?idnv="+idnv,
                data: null,
                dataType: "json",  
                contentType: "application/json; charset=utf-8",  
                success: function (data) {
                    console.log(data);
                    if(data == null){
                        alert("Nhân viên này đã thêm");
                    }
                    else{
                        var a = $("#table-nhan-vien").DataTable();
                        var b = '<button class="btn btn-danger btn-sm delete-nv" value="'+data.nvId+'"><i class="fas fa-trash"></i></button>';
                        a.row.add([data.nvId,data.nvTen,data.nvSdt,data.nvEmail,data.nhiemvu,b]).draw();
                    }
                },
                error: function (req, status, error) {
                    console.log(msg);
                }
            }); 
        }
    })
    $('#table-nhan-vien').on( 'click', '.delete-nv', function () {
        var idnv = $(this).val();
        $.ajax({
            type: "GET",
            url: "/Doan/xoanhanvien/?idnv="+idnv,
            data: null,
            dataType: "json",  
            contentType: "application/json; charset=utf-8",  
            success: function (data) {
                console.log(data);
            },
            error: function (req, status, error) {
                console.log(msg);
            }
        });
        tablenv.row($(this).parents('tr')).remove().draw();
    } );
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
    var DateOfBirth = [0, 0, 0];
    $("#ngay").change(() => {
        DateOfBirth[0] = $("#ngay").val();
        $("#NvNgaysinh").val(DateOfBirth[2] + "-" + DateOfBirth[1] + "-" + DateOfBirth[0]);
    });
    $("#thang").change(() => {
        DateOfBirth[1] = $("#thang").val();
        $("#NvNgaysinh").val(DateOfBirth[2] + "-" + DateOfBirth[1] + "-" + DateOfBirth[0]);
    });
    $("#nam").change(() => {
        DateOfBirth[2] = $("#nam").val();
        $("#NvNgaysinh").val(DateOfBirth[2] + "-" + DateOfBirth[1] + "-" + DateOfBirth[0]);
        $(".ngaysinhhide").hide();
    });
});
/*function ValidateSelectList() {
    if ($("#ToudId")[0].selectedIndex = 0) {
        $("#Tour_Id").text("ádhasd");
        return false;
    } else {
        return true;
    }
}*/

$("#DoanSL").change(() => {
    $("#CreateDoan").attr("href", "/ChiPhi/Create/" + $("#DoanSL").val());
    $("#LinkDoan").attr("href", "/ChiPhi/" + $("#DoanSL").val());
});

$("#ExpandTest").click(() => {
    if ($("#Event").css("display") == "block") {
        $("#Event").css("display", "none");
    } else {
        $("#Event").css("display", "block");
    }
});
$("#ChonTour").change(() => {
    $("#ThongKeTour").attr("href", "/ThongKe/Details/" + $("#ChonTour")[0].value);
});
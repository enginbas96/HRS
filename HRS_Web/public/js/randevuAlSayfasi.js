$('#iller').empty().append('<option value=""> - İlinizi Seçiniz - </option>');
$('#hastaneler').empty().append('<option value=""> - Önce İlinizi Seçiniz - </option>');
$('#poliklinikler').empty().append('<option value=""> - Önce İlinizi Seçiniz - </option>');
$('#hekimler').empty().append('<option value=""> - Önce İlinizi Seçiniz - </option>');
    $.get("/A", function (data) {
        $.each(data, function (key, iller) {
            $('#iller').append('<option value="' + iller.il + '">' + iller.il + '</option>');
        });
    });
$('#hastaneler').prop('disabled', true);
$('#hekimler').prop('disabled', true);
$('#poliklinikler').prop('disabled', true);
$('#randevuTarihi').prop('disabled', true);
$('#randevuTarihi').val('');
$('.saatButon').prop('disabled', true);



$('#iller').on('change', function () {
    var il_ad = $(this).val();
    $('#hastaneler').empty().append('<option value=""> - Hastaneyi Seçiniz - </option>');
    $('#poliklinikler').empty().append('<option value=""> - Önce Hastaneyi Seçiniz - </option>');
    $('#hekimler').empty().append('<option value=""> - Önce Hastaneyi Seçiniz - </option>');
    $.get("/B", {il :  il_ad}, function (data) {
        $.each(data, function (key, hastaneler) {
            $('#hastaneler').append('<option value="' + hastaneler.hastaneAdi + '">' + hastaneler.hastaneAdi + '</option>');
        });
    });
    $('#hastaneler').prop('disabled', false);
    $('#poliklinikler').prop('disabled', true);
    $('#hekimler').prop('disabled', true);
    $('#randevuTarihi').prop('disabled', true);
    $('#randevuTarihi').val('');
    $('.saatButon').prop('disabled', true);
});



$('#hastaneler').on('change', function () {
    var hastane_ad = $(this).val();
    $('#poliklinikler').empty().append('<option value=""> - Poliklinik Seçiniz - </option>');
    $('#hekimler').empty().append('<option value=""> - Önce Poliklinik Seçiniz - </option>');
    $.get("/C", {hastaneAdi : hastane_ad}, function (data) {
        $.each(data, function (key, poliklinikler) {
            $('#poliklinikler').append('<option value="' + poliklinikler.poliklinikAdi + '">' + poliklinikler.poliklinikAdi + '</option>');
        });
    });
    $('#hastaneler').prop('disabled', false);
    $('#poliklinikler').prop('disabled', false);
    $('#hekimler').prop('disabled', true);
    $('#randevuTarihi').prop('disabled', true);
    $('#randevuTarihi').val('');
    $('.saatButon').prop('disabled', true);
});



$('#poliklinikler').on('change', function () {
    var poliklinik_ad = $(this).val();
    var hastane_ad = $('#hastaneler').val();
    $('#hekimler').empty().append('<option value=""> - Doktor Seçiniz - </option>');
    $.get("/D", {poliklinikAdi: poliklinik_ad, hastaneAdi: hastane_ad}, function (data) {
        $.each(data, function (key, doktorlar) {
            $('#hekimler').append('<option value="' + doktorlar.tc + '">' +doktorlar.unvan +" "+ doktorlar.adsoyad + '</option>');
        });
    });
    $('#hastaneler').prop('disabled', false);
    $('#poliklinikler').prop('disabled', false);
    $('#hekimler').prop('disabled', false);
    $('#randevuTarihi').prop('disabled', true);
    $('#randevuTarihi').val('');
    $('.saatButon').prop('disabled', true);
});

$('#hekimler').on('change', function () {
    $('#hastaneler').prop('disabled', false);
    $('#poliklinikler').prop('disabled', false);
    $('#hekimler').prop('disabled', false);
    $('#randevuTarihi').prop('disabled', false);
    $('#randevuTarihi').val('');
    $('.saatButon').prop('disabled', true);
});

$(document).ready(function() {
    var minDate = new Date();
    minDate.setDate(minDate.getDate() + 1);
    var minDateStr = minDate.toISOString().split('T')[0];
    $('#randevuTarihi').attr('min', minDateStr);
    $('#randevuTarihi').on('change', function () {
        var tarih = $(this).val();
        var today = new Date().toISOString().split('T')[0];
        if(tarih < today)
        {
            $('#uyariMesaj').text('Lütfen gelecek zamandan bir tarih seçiniz.');
            $(this).val('');
            return;
        }
        else if (!isWeekday(tarih)) {
            $('#uyariMesaj').text('Lütfen sadece hafta içi günlerini seçiniz.');
            $(this).val('');
            return;
        }
        else{
            $('#uyariMesaj').text('');
            $('.saatButon').prop('disabled', false);
        }
        //Saat verilerini Çek
        var formattedDate = formatDate(tarih);
        var hastane_ad = $('#hastaneler').val();
        var poliklinik_ad = $('#poliklinikler').val();
        var hekim_tc = $('#hekimler').val();
        $('.saatButon').prop('disabled', false);
        $.get("/E", {tarih: formattedDate, hastaneAdi: hastane_ad, poliklinikAdi: poliklinik_ad, hekimTC: hekim_tc}, function (data) {
            console.log(data);
            $.each(data, function(index, value) {
                $('.saatButon[value="' + value.saat + '"]').prop('disabled', true);
            });
        });
    });
    function formatDate(date) {
        var parts = date.split('-');
        var day = parseInt(parts[2]);
        var month = (parts[1]);
        var year = parts[0];
        return day + '.' + month + '.' + year;
    }
    function isWeekday(date) {
        var day = new Date(date).getDay();
        return day !== 0 && day !== 6;
    }
});

var hiddenInput = document.getElementById('saat');
//var randevuSaati;
function saatAl(clickedButton){
    //randevuSaati = clickedButton.value;
    hiddenInput.value = clickedButton.value;
    console.log($('#saat').val());
}





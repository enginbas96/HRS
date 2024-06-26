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
$('#cf-submit').prop('disabled', true);

const submitButton = document.getElementById('cf-submit');
submitButton.textContent = 'Lütfen randevu istediğiniz ili seçiniz.';



$('#iller').on('change', function () {
    var il_ad = $(this).val();
    $('#hastaneler').empty().append('<option value=""> - Hastaneyi Seçiniz - </option>');
    $('#poliklinikler').empty().append('<option value=""> - Önce Hastaneyi Seçiniz - </option>');
    $('#hekimler').empty().append('<option value=""> - Önce Hastaneyi Seçiniz - </option>');
    $.get("/B", {il: il_ad}, function (data) {
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
    $('#cf-submit').prop('disabled', true);
    submitButton.textContent = 'Lütfen randevu istediğiniz hastaneyi seçiniz.';
});


$('#hastaneler').on('change', function () {
    var hastane_ad = $(this).val();
    $('#poliklinikler').empty().append('<option value=""> - Poliklinik Seçiniz - </option>');
    $('#hekimler').empty().append('<option value=""> - Önce Poliklinik Seçiniz - </option>');
    $.get("/C", {hastaneAdi: hastane_ad}, function (data) {
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
    $('#cf-submit').prop('disabled', true);
    submitButton.textContent = 'Lütfen randevu istediğiniz polikliniği seçiniz.';
});


$('#poliklinikler').on('change', function () {
    var poliklinik_ad = $(this).val();
    var hastane_ad = $('#hastaneler').val();
    $('#hekimler').empty().append('<option value=""> - Doktor Seçiniz - </option>');
    $.get("/D", {poliklinikAdi: poliklinik_ad, hastaneAdi: hastane_ad}, function (data) {
        $.each(data, function (key, doktorlar) {
            $('#hekimler').append('<option value="' + doktorlar.tc + '">' + doktorlar.unvan + " " + doktorlar.adsoyad + '</option>');
        });
    });
    $('#hastaneler').prop('disabled', false);
    $('#poliklinikler').prop('disabled', false);
    $('#hekimler').prop('disabled', false);
    $('#randevuTarihi').prop('disabled', true);
    $('#randevuTarihi').val('');
    $('.saatButon').prop('disabled', true);
    $('#cf-submit').prop('disabled', true);
    submitButton.textContent = 'Lütfen randevu istediğiniz doktoru seçiniz.';
});

$('#hekimler').on('change', function () {
    $('#hastaneler').prop('disabled', false);
    $('#poliklinikler').prop('disabled', false);
    $('#hekimler').prop('disabled', false);
    $('#randevuTarihi').prop('disabled', false);
    $('#randevuTarihi').val('');
    $('.saatButon').prop('disabled', true);
    $('#cf-submit').prop('disabled', true);
    submitButton.textContent = 'Lütfen randevu istediğiniz tarihi seçiniz.';
});

$(document).ready(function () {
    var minDate = new Date();
    minDate.setDate(minDate.getDate() + 1);
    var minDateStr = minDate.toISOString().split('T')[0];
    $('#randevuTarihi').attr('min', minDateStr);
    $('#randevuTarihi').on('change', function () {
        var tarih = $(this).val();
        var today = new Date().toISOString().split('T')[0];
        if (tarih < today) {
            $('#uyariMesaj').text('Lütfen gelecek zamandan bir tarih seçiniz.');
            $(this).val('');
            return;
        } else if (!isWeekday(tarih)) {
            $('#uyariMesaj').text('Lütfen sadece hafta içi günlerini seçiniz.');
            $(this).val('');
            return;
        } else {
            $('#uyariMesaj').text('');
            $('.saatButon').prop('disabled', false);
        }
        //Saat verilerini Çek
        var formattedDate = formatDate(tarih);
        var hastane_ad = $('#hastaneler').val();
        var poliklinik_ad = $('#poliklinikler').val();
        var hekim_tc = $('#hekimler').val();
        submitButton.textContent = 'Lütfen randevu istediğiniz saati seçiniz.';
        $('.saatButon').prop('disabled', false);
        $.get("/E", {
            tarih: formattedDate,
            hastaneAdi: hastane_ad,
            poliklinikAdi: poliklinik_ad,
            hekimTC: hekim_tc
        }, function (data) {
            $.each(data, function (index, value) {
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

function saatAl(clickedButton) {
    hiddenInput.value = clickedButton.value;
    saatButonRengiDegistir(clickedButton);
    submitButton.textContent = 'Randevu Al';
    $('#cf-submit').prop('disabled', false);
}

function saatButonRengiDegistir(clickedButton) {
    $('.saatButon').css('background-color', '#99ccff');
    $('.saatButon').css('border-color', 'transparent');

    $(clickedButton).css('background-color', 'yellow');
    $(clickedButton).css('border-color', '#333');

    $('.saatButon:disabled').css('background-color', 'grey');
    $('.saatButon:disabled').css('color', 'black');
}


document.addEventListener('DOMContentLoaded', function () {
    const form = document.querySelector('form');
    const ilSelect = document.getElementById('iller');
    const hastaneSelect = document.getElementById('hastaneler');
    const poliklinikSelect = document.getElementById('poliklinikler');
    const hekimSelect = document.getElementById('hekimler');
    const randevuTarihiInput = document.getElementById('randevuTarihi');
    const saatInput = document.getElementById('saat');

    form.addEventListener('submit', function (event) {
        let valid = true;
        let errorMessage = 'Lütfen aşağıdaki alanları doldurun:\n';

        if (!ilSelect.value) {
            valid = false;
            errorMessage += '- İl\n';
        }

        if (!hastaneSelect.value) {
            valid = false;
            errorMessage += '- Hastane\n';
        }

        if (!poliklinikSelect.value) {
            valid = false;
            errorMessage += '- Poliklinik\n';
        }

        if (!hekimSelect.value) {
            valid = false;
            errorMessage += '- Doktor\n';
        }

        if (!randevuTarihiInput.value) {
            valid = false;
            errorMessage += '- Randevu Tarihi\n';
        }

        if (!saatInput.value) {
            valid = false;
            errorMessage += '- Randevu Saati\n';
        }

        if (!valid) {
            alert(errorMessage);
            event.preventDefault();
        }
    });
});


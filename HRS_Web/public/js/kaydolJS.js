function karakterKontrol(event) {
    var inputElement = event.target;
    var inputValue = inputElement.value;
    var filteredValue = '';

    // Sadece harflerin girilmesine izin ver ve büyük/küçük harf kontrolü yap
    for (var i = 0; i < inputValue.length; i++) {
        var charStr = inputValue.charAt(i);
        if (charStr.match(/^[a-zA-ZğüşöçİĞÜŞÖÇ]+$/)) {
            if (i == 0) {
                filteredValue += charStr.toUpperCase();
            } else {
                filteredValue += charStr.toLowerCase();
            }
        }
    }
    inputElement.value = filteredValue;
}
function rakamKontrol(event) {
    var inputElement = event.target;
    var inputValue = inputElement.value;
    var filteredValue = '';

    // Sadece rakamların girilmesine izin ver
    for (var i = 0; i < inputValue.length; i++) {
        var charStr = inputValue.charAt(i);
        if (charStr.match(/^[0-9]+$/)) {
            filteredValue += charStr;
        }
    }
    inputElement.value = filteredValue;
}
function kontrolEt() {
    var adInput = document.getElementById('ad');
    var adValue = adInput.value.trim();

    var soyadInput = document.getElementById('soyad');
    var soyadValue = soyadInput.value.trim();

    var epostaInput = document.getElementById('eposta');
    var epostaValue = epostaInput.value.trim();

    var dogumyiliInput = document.getElementById('dogumyili');
    var dogumyiliValue = dogumyiliInput.value.trim();

    var tcInput = document.getElementById('tc');
    var tcValue = tcInput.value.trim();

    var passwordInput = document.getElementById('password');
    var passwordValue = passwordInput.value;

    var cinsiyetInput = document.querySelector('input[name="cinsiyet"]:checked');
    var cinsiyetValue = cinsiyetInput ? cinsiyetInput.value : "";

    if (adValue === "" || soyadValue === "" || epostaValue === "" || dogumyiliValue === "" || tcValue === "" || passwordValue === "" || cinsiyetValue === "") {
        alert('Tüm alanları doldurunuz!');
        return false;
    }
    if (tcValue.length !== 11) {
        alert('TC Kimlik numarası 11 karakter olmalıdır!');
        return false;
    }
    if (passwordValue.length < 8) {
        alert('Şifreniz en az 8 karakter olmalıdır!');
        return false;
    }
    if (adValue.length < 2) {
        alert('Ad en az 2 karakter içermelidir!');
        return false;
    }
    if (soyadValue.length < 2) {
        alert('Soyad en az 2 karakter içermelidir!');
        return false;
    }
    if (!dogumyiliValue.match(/^\d+$/)) {
        alert('Doğum yılı sadece rakamlardan oluşmalıdır!');
        return false;
    }
    var currentYear = new Date().getFullYear();
    var maxBirthYear = currentYear - 120;
    if (dogumyiliValue < maxBirthYear) {
        alert('Lütfen geçerli bir doğum yılı giriniz.');
        return false;
    }
    return true;
}

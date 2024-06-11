<!doctype html>
<html lang="en">
<head>
    <title>Hakkımızda | ABC Özel Sağlık Hizmetleri Randevu Sistemi</title>

    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=Edge">
    <meta name="description" content="">
    <meta name="keywords" content="">
    <meta name="author" content="Tooplate">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">

    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/font-awesome.min.css">
    <link rel="stylesheet" href="css/animate.css">
    <link rel="stylesheet" href="css/owl.carousel.css">
    <link rel="stylesheet" href="css/owl.theme.default.min.css">
    <link rel="stylesheet" href="css/tooplate-style.css">
</head>
<body id="top" data-spy="scroll" data-target=".navbar-collapse" data-offset="50">
<!-- PRE LOADER -->
<section class="preloader">
    <div class="spinner">
        <span class="spinner-rotate"></span>
    </div>
</section>
<!-- HEADER -->
<header>
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-sm-5">
                <p>ABC Özel Sağlık Hizmetleri</p>
            </div>
            <div class="col-md-8 col-sm-7 text-align-right">
                <span class="phone-icon"><i class="fa fa-phone"></i> 0-(216)-444-4-444</span>
                <span class="date-icon"><i class="fa fa-calendar-plus-o"></i> 6:00 - 22:00 (Pazartesi-Cuma)</span>
                <span class="email-icon"><i class="fa fa-envelope-o"></i> <a href="#">bilgi@abcsaglik.com</a></span>
            </div>
        </div>
    </div>
</header>
@auth()
    <!-- MENU -->
    <section class="navbar navbar-default navbar-static-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
                <button class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon icon-bar"></span>
                    <span class="icon icon-bar"></span>
                    <span class="icon icon-bar"></span>
                </button>
                <!-- lOGO TEXT HERE -->
                <a href="{{route("anaSayfa")}}" class="navbar-brand"><i class="fa fa-h-square"></i>er şeyden önce sağlık</a>
            </div>
            <!-- MENU LINKS -->
            <div class="collapse navbar-collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="{{route("anaSayfa")}}" class="smoothScroll">Anasayfa</a></li>
                    <li><a href="{{route("hakkimizdaSayfasi")}}" class="smoothScroll">Hakkımızda</a></li>
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Bize Dair <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="{{route("hastanelerSayfasi")}}" class="smoothScroll">Hastanelerimiz</a></li>
                            <li><a href="{{route("doktorlarSayfasi")}}" class="smoothScroll">Uzman Kadromuz</a></li>
                        </ul>
                    </li>
                    <li><a href="{{route("iletisimSayfasi")}}" class="smoothScroll">İletişim</a></li>
                    <li class="appointment-profil"><a href="{{route("profilSayfasi")}}">Profil</a></li>
                    <li class="appointment-btn"><a href="{{route("randevularSayfasi")}}">Randevularım</a></li>
                    <li class="appointment-btn1"><a href="{{route('cikis')}}">Çıkış Yap</a></li>
                </ul>
            </div>
        </div>
    </section>
@endauth
@guest()
    <!-- MENU -->
    <section class="navbar navbar-default navbar-static-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
                <button class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon icon-bar"></span>
                    <span class="icon icon-bar"></span>
                    <span class="icon icon-bar"></span>
                </button>
                <!-- lOGO TEXT HERE -->
                <a href="{{route("anaSayfa")}}" class="navbar-brand"><i class="fa fa-h-square"></i>er şeyden önce sağlık</a>
            </div>
            <!-- MENU LINKS -->
            <div class="collapse navbar-collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="{{route("anaSayfa")}}" class="smoothScroll">Anasayfa</a></li>
                    <li><a href="{{route("hakkimizdaSayfasi")}}" class="smoothScroll">Hakkımızda</a></li>
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Bize Dair <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="{{route("hastanelerSayfasi")}}" class="smoothScroll">Hastanelerimiz</a></li>
                            <li><a href="{{route("doktorlarSayfasi")}}" class="smoothScroll">Uzman Kadromuz</a></li>
                        </ul>
                    </li>
                    <li><a href="{{route("iletisimSayfasi")}}" class="smoothScroll">İletişim</a></li>
                    <li class="appointment-btn"><a href="{{route("kaydolSayfasi")}}">Kayıt Ol</a></li>
                    <li class="appointment-btn"><a href="{{route("girisSayfasi")}}">Giriş Yap</a></li>
                </ul>
            </div>
        </div>
    </section>
@endguest
<section id="about">
    <div class="container">
        <div class="row">

            <div class="col-md-6 col-sm-6">
                <div class="about-info">
                    <h2 class="wow fadeInUp" data-wow-delay="0.6s">ABC Özel Sağlık Hizmetleri'ne Hoş Geldiniz </h2>
                    <div class="wow fadeInUp" data-wow-delay="0.8s">
                        <p>1996 yılında İstanbul'da kurulan ABC Özel Sağlık Hizmetleri, sağlık sektöründe 25 yılı aşkın
                            deneyimiyle Türkiye'nin en önde gelen sağlık kuruluşlarından biri olmuştur. Hastanemiz,
                            modern tıbbi cihazlar ve uzman kadrosuyla, her zaman en kaliteli sağlık hizmetini sunmayı
                            hedeflemektedir.</p>
                        <p>Kuruluşumuzun ilk yıllarında, sadece İstanbul'da tek bir hastane ile hizmet vermeye başladık.
                            Ancak yıllar içerisinde, kaliteli ve güvenilir sağlık hizmetlerimiz sayesinde hızla
                            büyüyerek, Türkiye genelinde yaygın bir sağlık ağı oluşturduk. Bugün itibariyle 20 farklı
                            ilde, toplamda 25 hastane ile geniş bir hizmet yelpazesi sunuyoruz.</p>
                        <p>Hastanelerimizde, her biri alanında uzman doktorlar, hemşireler ve sağlık personeli görev
                            almaktadır. Ayrıca, en son teknolojik gelişmeleri takip ederek, hastalarımıza en güncel ve
                            etkili tedavi yöntemlerini sunmaktayız. Geniş hizmet yelpazemiz içerisinde; acil servis,
                            genel cerrahi, kardiyoloji, onkoloji, kadın doğum, çocuk sağlığı ve hastalıkları, ortopedi
                            gibi birçok branş bulunmaktadır.</p>
                        <p>ABC Özel Sağlık Hizmetleri olarak, sadece tedavi hizmetleriyle sınırlı kalmayıp, aynı zamanda
                            sağlığın korunması ve iyileştirilmesi için de çeşitli programlar ve etkinlikler
                            düzenliyoruz. Sağlık seminerleri, bilinçlendirme kampanyaları ve düzenli kontroller gibi
                            hizmetlerimizle, halkımızın sağlık bilincini artırmayı hedefliyoruz.</p>
                        <p>Hastalarımızın memnuniyeti bizim için en büyük önceliktir. Bu nedenle, her hastanemizde hasta
                            odaklı hizmet anlayışını benimseyerek, her hastamızın bireysel ihtiyaçlarına özel çözümler
                            sunmaktayız. ABC Özel Sağlık Hizmetleri, sağlığınıza verdiğiniz önemin bilincinde olarak,
                            sizin ve sevdiklerinizin sağlığını en üst düzeyde korumak için buradayız.</p>
                        <p>Misyonumuz, toplumun her kesimine nitelikli sağlık hizmeti sunmak ve sağlık alanında öncü bir
                            kuruluş olmaktır. Vizyonumuz ise, global sağlık standartlarını Türkiye'ye taşıyarak,
                            uluslararası alanda da tanınan ve tercih edilen bir sağlık kuruluşu olmaktır.</p>
                    </div>
                    <br>
                    <br>
                    <br>
                    <figure class="profile wow fadeInUp" data-wow-delay="1s">
                        <img src="images/author-image.jpg" class="img-responsive" alt="">
                        <figcaption>
                            <h3>Dr. Hasan YORGUN</h3>
                            <p>Başhekim</p>
                        </figcaption>
                    </figure>
                </div>
            </div>

        </div>
    </div>
</section>
<br>
<!-- FOOTER -->
<footer data-stellar-background-ratio="5">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-sm-4">
                <div class="footer-thumb">
                    <h4 class="wow fadeInUp" data-wow-delay="0.4s">İletişim Bilgileri</h4>
                    <p>Hızlı ve etkili iletişim için bize ulaşın. Sağlığınızla ilgili herhangi bir sorunuz, öneriniz
                        veya isteğiniz mi var? Size yardımcı olmaktan mutluluk duyarız.</p>

                    <div class="contact-info">
                        <p><i class="fa fa-phone"></i> 0-(216)-444-4-444</p>
                        <p><i class="fa fa-envelope-o"></i> <a href="#">bilgi@abcsaglik.com</a></p>
                    </div>
                </div>
            </div>
            <div class="col-md-4 col-sm-4">
                <div class="footer-thumb">
                    <div class="opening-hours">
                        <h4 class="wow fadeInUp" data-wow-delay="0.4s">Çalışma Saatlerimiz</h4>
                        <p>Pazartesi - Cuma <span>06:00 - 22:00</span></p>
                        <p>Cumartesi <span>09:00 - 20:00</span></p>
                        <p>Pazar <span>Kapalı</span></p>
                        <p>Acil Servisimiz 7/24 Hizmetinizdedir</p>
                    </div>
                    <ul class="social-icon">
                        <li><a href="https://www.facebook.com" class="fa fa-facebook-square" attr="facebook icon"></a>
                        </li>
                        <li><a href="https://www.x.com" class="fa fa-twitter"></a></li>
                        <li><a href="https://www.instagra.com" class="fa fa-instagram"></a></li>
                    </ul>
                </div>
            </div>
            <div class="col-md-12 col-sm-12 border-top">
                <div class="col-md-4 col-sm-6">
                    <div class="copyright-text">
                        <p>Copyright &copy; 2009 ABC Sağlık

                            | Tasarım: <a href="mailto:engin.bas96@gmail.com" target="_parent">ENGBA</a></p>
                    </div>
                </div>
                <div class="col-md-6 col-sm-6">
                </div>
                <div class="col-md-2 col-sm-2 text-align-center">
                    <div class="angle-up-btn">
                        <a href="#top" class="smoothScroll wow fadeInUp" data-wow-delay="1.2s"><i
                                class="fa fa-angle-up"></i></a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</footer>
<!-- SCRIPTS -->
<script src="js/jquery.js"></script>
<script src="js/bootstrap.min.js"></script>
<script src="js/jquery.sticky.js"></script>
<script src="js/jquery.stellar.min.js"></script>
<script src="js/wow.min.js"></script>
<script src="js/smoothscroll.js"></script>
<script src="js/owl.carousel.min.js"></script>
<script src="js/custom.js"></script>
</body>
</html>




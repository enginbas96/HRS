import {
  Alert,
  Dimensions,
  FlatList,
  Image,
  Modal,
  StyleSheet,
  Text,
  Touchable,
  TouchableOpacity,
  View,
} from 'react-native';
import React, {useEffect, useState} from 'react';
import {Button, CheckBox} from '../../components';
import DateTimePicker from 'react-native-ui-datepicker';
const windowWidth = Dimensions.get('window').width;
const windowHeight = Dimensions.get('window').height;
import dayjs from 'dayjs';
import {arrow} from '../../assets/icons';
import {RouteNames, url} from '../../config';

const index = props => {
  const {navigation, route} = props;
  const tc = route.params?.tc;
  console.log('tc', tc);
  const saat = [
    {name: '8.00', saat: '8', active: true},
    {name: '9.00', saat: '9', active: true},
    {name: '10.00', saat: '10', active: true},
    {name: '11.00', saat: '11', active: true},
    {name: '13.00', saat: '13', active: true},
    {name: '14.00', saat: '14', active: true},
    {name: '15.00', saat: '15', active: true},
    {name: '16.00', saat: '16', active: true},
  ];
  const [date, setDate] = useState(dayjs());
  const [tarih, setTarih] = useState();
  const [dateOpen, setDateOpen] = useState(false);
  const [dataIl, setDataIl] = useState([]);
  const [dataHastane, setDataHastane] = useState([]);
  const [dataPoliklinik, setDataPoliklinik] = useState([]);
  const [dataDoktor, setDataDoktor] = useState([]);
  const [secilenIl, setSecilenIl] = useState();
  const [secilenHastane, setSecilenHastane] = useState();
  const [secilenPoliklinik, setSecilenPoliklinik] = useState();
  const [secilenDoktor, setSecilenDoktor] = useState();
  const [newSaat, setNewSaat] = useState(saat);
  const [secilenSaat, setSecilenSaat] = useState();
  const [randevu, setRandevu] = useState(false);

  const newDate = new Date();
  useEffect(() => {
    fetch(url.baseUrl + '/api/A')
      .then(response => response.json())
      .then(data => {
        console.log(data); // API'den gelen veriyi konsola yazdırır
        const il = data.map(index => {
          return {name: index.il};
        });
        setDataIl(il);
      })
      .catch(error => {
        console.error('Error:', error); // Hata durumunda konsola hata yazdırır
      });
  }, []);
  const ilSecildi = item => {
    console.log('first');
    setSecilenDoktor();
    setSecilenPoliklinik();
    setSecilenHastane();
    setTarih();
    setSecilenSaat();
    setDataPoliklinik();
    setDataDoktor();
    fetch(url.baseUrl + `/api/B?il=${item.name}`)
      .then(response => response.json())
      .then(data => {
        console.log(data); // API'den gelen veriyi konsola yazdırır
        const hastane = data.map(index => {
          return {name: index.hastaneAdi};
        });
        setDataHastane(hastane);
      })
      .catch(error => {
        console.error('Error:', error); // Hata durumunda konsola hata yazdırır
      });
  };
  const hastaneSecildi = item => {
    setSecilenDoktor();
    setSecilenPoliklinik();
    setTarih();
    setSecilenSaat();
    console.log('first');
    fetch(url.baseUrl + `/api/C?hastaneAdi=${item.name}`)
      .then(response => response.json())
      .then(data => {
        console.log(data); // API'den gelen veriyi konsola yazdırır
        const polikilik = data.map(index => {
          return {name: index.poliklinikAdi};
        });
        setDataPoliklinik(polikilik);
        console.log('polikilik', polikilik);
      })
      .catch(error => {
        console.error('Error:', error); // Hata durumunda konsola hata yazdırır
      });
  };
  const poliklinikSecildi = item => {
    setSecilenDoktor();
    setTarih();
    setSecilenSaat();
    console.log('secilen hasten', secilenHastane);
    console.log('first');
    fetch(
      url.baseUrl +
        `/api/D?hastaneAdi=${secilenHastane.name}&poliklinikAdi=${item.name}`,
    )
      .then(response => response.json())
      .then(data => {
        console.log(data); // API'den gelen veriyi konsola yazdırır
        const doktor = data.map(index => {
          return {name: index.adsoyad, tc: index.tc};
        });
        setDataDoktor(doktor);
        console.log('doktor', doktor);
      })
      .catch(error => {
        console.error('Error:', error); // Hata durumunda konsola hata yazdırır
      });
  };
  const tarihSecildi = item => {
    setSecilenSaat();
    console.log('secilen hasten', secilenHastane);
    console.log('secilen pol', secilenPoliklinik);
    console.log('secilen pol', secilenDoktor);
    fetch(
      url.baseUrl +
        `/api/E?hastaneAdi=${secilenHastane.name}&poliklinikAdi=${secilenPoliklinik.name}&hekimTC=${secilenDoktor.tc}&tarih=${item}`,
    )
      .then(response => response.json())
      .then(data => {
        console.log(data); // API'den gelen veriyi konsola yazdırır
        const randevuSaat = data.map(index => {
          return {saat: index.saat};
        });
        const appsaat = saat.map(index => {
          randevuSaat.forEach(element => {
            if (index.saat === element.saat) {
              index.active = false;
            }
          });
          return index;
        });
        setNewSaat(appsaat);
        console.log('randevuSaat', randevuSaat);
      })
      .catch(error => {
        console.error('Error:', error); // Hata durumunda konsola hata yazdırır
      });
  };
  const randevuOlustur = item => {
    const dataToSend = {
      tc: tc,
      hastane: secilenHastane.name,
      poliklinik: secilenPoliklinik.name,
      hekim: secilenDoktor.tc,
      randevuTarihi: tarih,
      saat: secilenSaat,
    };
    setRandevu(false);
    if (
      tc &&
      secilenHastane &&
      secilenPoliklinik &&
      secilenDoktor &&
      tarih &&
      secilenSaat
    ) {
      fetch(url.baseUrl + `/api/randevuAlMobil`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(dataToSend),
      })
        .then(response => response.json())
        .then(data => {
          console.log('Post isteği yanıtı:', data);
          if (data.success === 'aynı güne randevu mecut') {
            Alert.alert('Hata', 'Aynı günde randevunuz bulunmaktadır!', [
              {text: 'Tamam', onPress: () => {}},
            ]);
          } else {
            setRandevu(true);
          }
        })
        .catch(error => {
          console.error('Post isteği hatası:', error);
        });
    } else {
      Alert.alert('Hata', 'Lütfen tüm alanları doldurun!', [
        {text: 'Tamam', onPress: () => {}},
      ]);
    }
  };
  useEffect(() => {
    if (randevu) {
      navigation.goBack();
    }
  }, [randevu]);
  return (
    <View style={{flex: 1}}>
      <View
        style={{
          margin: windowWidth * 0.05,
          flexDirection: 'row',
        }}>
        <TouchableOpacity
          onPress={() => {
            navigation.goBack();
          }}
          style={{
            padding: 5,
            borderRadius: windowWidth,
          }}>
          <Image
            style={{
              width: windowWidth * 0.08,
              height: windowWidth * 0.08,
              tintColor: '#649df1',
            }}
            source={arrow}
          />
        </TouchableOpacity>
        <View>
          <Text
            style={{
              fontSize: windowWidth * 0.07,
              fontWeight: '800',
              color: 'black',
              marginLeft: 20,
            }}>
            Randevu Oluşturma
          </Text>
        </View>
      </View>
      <CheckBox
        name="İl"
        DATA={dataIl}
        onChange={ilSecildi}
        onText={setSecilenIl}
        text={secilenIl}
      />
      <CheckBox
        name="Hastane"
        DATA={dataHastane}
        onChange={hastaneSecildi}
        onText={setSecilenHastane}
        text={secilenHastane}
      />
      <CheckBox
        name="Poliklinik"
        DATA={dataPoliklinik}
        onChange={poliklinikSecildi}
        onText={setSecilenPoliklinik}
        text={secilenPoliklinik}
      />
      <CheckBox
        name="Doktor"
        DATA={dataDoktor}
        onChange={() => {
          setTarih();
          setSecilenSaat();
        }}
        onText={setSecilenDoktor}
        text={secilenDoktor}
      />
      <View style={{width: windowWidth, alignItems: 'center'}}>
        <View style={{width: windowWidth * 0.8}}>
          <Text style={{fontSize: 17, fontWeight: '700', color: '#649df1'}}>
            Tarih
          </Text>
        </View>
        <TouchableOpacity
          style={{
            width: windowWidth * 0.8,
            alignItems: 'center',
            paddingVertical: 10,
            backgroundColor: '#e1ecfe',
            borderRadius: 10,
            borderWidth: 1,
            borderColor: '#649df1',
          }}
          onPress={() => {
            setDateOpen(true);
          }}>
          <Text style={{color: 'black', fontWeight: '600'}}>
            {tarih ? tarih : 'Tarih Seç'}
          </Text>
        </TouchableOpacity>
      </View>
      <Modal
        animationType="slide"
        transparent={true}
        visible={dateOpen}
        onRequestClose={() => {
          setDateOpen(!dateOpen);
        }}>
        <View
          style={{
            width: windowWidth,
            height: windowHeight,
            alignItems: 'center',
            justifyContent: 'flex-end',
            backgroundColor: 'rgba(0, 0, 0, 0.4)',
          }}>
          <View
            style={{
              backgroundColor: 'white',
              width: windowWidth * 0.9,
              borderRadius: 20,
              padding: 20,
              marginBottom: 20,
            }}>
            <DateTimePicker
              mode="single"
              date={date}
              onChange={params => {
                console.log('params.date', params.date);
                const dateApp = new Date(params.date);
                const year = dateApp.getUTCFullYear();
                const month = dateApp.getUTCMonth() + 1;
                const day = dateApp.getUTCDate();
                const formattedMonth = month < 10 ? `0${month}` : `${month}`;
                const formattedDate = `${day}.${formattedMonth}.${year}`;
                setTarih(formattedDate);
                tarihSecildi(formattedDate);
                setDate(params.date);
                setDateOpen(false);
              }}
              minDate={newDate}
              selectedItemColor="#649df1"
              headerButtonsPosition="right"
              headerButtonColor="#649df1"
              headerTextStyle={{color: '#649df1', fontSize: 20}}
              headerButtonSize={20}
              headerButtonStyle={{
                shadowOffset: {width: 5, height: 5},
                elevation: 5,
                backgroundColor: 'white',
                borderRadius: 5,
              }}
              firstDayOfWeek={1}
            />
          </View>
        </View>
      </Modal>
      {tarih && (
        <View style={{alignItems: 'center', marginTop: 20}}>
          <View style={{width: windowWidth * 0.8}}>
            <Text style={{fontSize: 17, fontWeight: '700', color: '#649df1'}}>
              Saatler
            </Text>
          </View>
          <View style={{width: windowWidth * 0.8 + 10}}>
            <FlatList
              data={newSaat}
              renderItem={({item}) => {
                console.log('item', item);
                return (
                  <TouchableOpacity
                    disabled={!item.active}
                    style={{
                      flex: 1,
                      justifyContent: 'center',
                      alignItems: 'center',
                      backgroundColor: item.active
                        ? secilenSaat === item.saat
                          ? '#649df1'
                          : '#e1ecfe'
                        : 'grey',
                      margin: 5,
                      padding: 10,
                      borderRadius: 10,
                      borderWidth: 1,
                      borderColor: item.active ? '#649df1' : 'black',
                    }}
                    onPress={() => {
                      setSecilenSaat(item.saat);
                    }}>
                    <Text
                      style={{
                        color: item.active
                          ? secilenSaat === item.saat
                            ? 'white'
                            : 'black'
                          : 'white',
                        fontWeight: '700',
                      }}>
                      {item.name}
                    </Text>
                  </TouchableOpacity>
                );
              }}
              numColumns={4}
            />
          </View>
        </View>
      )}
      <View style={{width: windowWidth, alignItems: 'center', marginTop: 20}}>
        <Button
          style={{
            width: windowWidth * 0.8,
            height: windowWidth * 0.1,
            backgroundColor: '#649df1',
            alignItems: 'center',
            justifyContent: 'center',
            borderRadius: windowWidth * 0.02,
            shadowColor: 'black',
            shadowOpacity: 0.4,
            shadowOffset: {width: 3, height: 3},
            shadowRadius: windowWidth * 0.02,
          }}
          textStyle={{
            fontSize: windowWidth * 0.04,
            color: 'white',
            fontWeight: '700',
          }}
          buttonName={'Randevu Oluştur'}
          onChange={() => {
            randevuOlustur();
          }}
        />
      </View>
    </View>
  );
};

export default index;

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#F5FCFF',
  },
});

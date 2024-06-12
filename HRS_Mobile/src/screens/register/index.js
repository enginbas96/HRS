import {
  Image,
  SafeAreaView,
  StyleSheet,
  Text,
  View,
  Dimensions,
  TouchableOpacity,
  ScrollView,
  Alert,
} from 'react-native';
import React, {useState} from 'react';
import {TextInput, Button} from '../../components';
import {logo} from '../../assets/icons';
import {RouteNames, url} from '../../config';
import {da} from 'date-fns/locale';

const windowWidth = Dimensions.get('window').width;
const windowHeight = Dimensions.get('window').height;

const Register = props => {
  console.log('url.baseUrl', url.baseUrl);
  const {navigation} = props;
  const [radioButton, setRadioButton] = useState();
  const [tc, setTc] = useState('');
  const [ad, setAd] = useState('');
  const [soyad, setSoyad] = useState('');
  const [password, setPassword] = useState('');
  const [eposta, setEposta] = useState('');
  const [dogumyili, setDogumyili] = useState('');

  const dataToSend = {
    tc: tc,
    password: password,
    ad: ad,
    soyad: soyad,
    eposta: eposta,
    dogumyili: dogumyili,
    cinsiyet: radioButton,
  };

  const kayitOl = () => {
    fetch(url.baseUrl + '/api/kayitOlMobil', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(dataToSend),
    })
      .then(response => response.json())
      .then(data => {
        console.log('Post isteği yanıtı:', data);
        if (!data.success) {
          navigation.navigate(RouteNames.HOME, {tc});
        } else {
          Alert.alert('Bu TC kimlik numarasına ait kullanıcı zaten mevcut.');
        }
      })
      .catch(error => {
        console.error('Post isteği hatası:', error);
      });
  };

  return (
    <ScrollView>
      <SafeAreaView
        style={{justifyContent: 'center', alignItems: 'center', flex: 1}}>
        <View style={[styles.general]}>
          <View>
            <Image
              resizeMode="contain"
              style={{height: windowWidth * 0.6}}
              source={logo}
            />
          </View>
        </View>
        <View
          style={{alignItems: 'center', marginVertical: windowWidth * 0.05}}>
          <View>
            <Text
              style={{
                fontSize: windowWidth * 0.06,
                fontWeight: '700',
                color: '#649df1',
              }}>
              Kayıt Ol
            </Text>
          </View>
        </View>
        <TextInput
          textInputName={'TC Kimlik No'}
          passwordText={false}
          onChangeText={setTc}
        />
        <TextInput
          textInputName={'Şifre'}
          passwordText={true}
          onChangeText={setPassword}
        />
        <TextInput
          textInputName={'Ad'}
          passwordText={false}
          onChangeText={setAd}
        />
        <TextInput
          textInputName={'Soyad'}
          passwordText={false}
          onChangeText={setSoyad}
        />
        <TextInput
          textInputName={'E Posta'}
          passwordText={false}
          onChangeText={setEposta}
        />
        <TextInput
          textInputName={'Doğum Yılı'}
          passwordText={false}
          onChangeText={setDogumyili}
        />
        <View style={{alignItems: 'center', marginTop: windowWidth * 0.05}}>
          <View style={{width: windowWidth * 0.8, flexDirection: 'row'}}>
            <TouchableOpacity
              onPress={() => {
                setRadioButton('Erkek');
              }}
              style={{flexDirection: 'row', marginRight: 20}}>
              <View
                style={{
                  width: 20,
                  height: 20,
                  backgroundColor:
                    radioButton === 'Erkek' ? '#649df1' : '#e1ecfe',
                  marginRight: 10,
                  borderColor: '#649df1',
                  borderWidth: 1,
                }}></View>
              <Text style={{color: 'black'}}>Erkek</Text>
            </TouchableOpacity>
            <TouchableOpacity
              onPress={() => {
                setRadioButton('Kadın');
              }}
              style={{flexDirection: 'row'}}>
              <View
                style={{
                  width: 20,
                  height: 20,
                  backgroundColor:
                    radioButton === 'Kadın' ? '#649df1' : '#e1ecfe',
                  marginRight: 10,
                  borderColor: '#649df1',
                  borderWidth: 1,
                }}></View>
              <Text style={{color: 'black'}}>Kadın</Text>
            </TouchableOpacity>
          </View>
        </View>

        <View style={{alignItems: 'center', marginTop: windowWidth * 0.05}}>
          <View style={{width: windowWidth * 0.8}}>
            <View
              style={{
                flexDirection: 'row',
                alignItems: 'center',
                justifyContent: 'space-between',
              }}>
              <Button
                style={{
                  width: windowWidth * 0.36,
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
                buttonName={'Kayıt Ol'}
                onChange={() => {
                  kayitOl();
                }}
              />
              <Button
                style={{
                  width: windowWidth * 0.36,
                  height: windowWidth * 0.1,
                  backgroundColor: 'white',
                  alignItems: 'center',
                  justifyContent: 'center',
                  borderRadius: windowWidth * 0.02,
                  borderWidth: 1,
                  borderColor: '#649df1',
                }}
                textStyle={{
                  fontSize: windowWidth * 0.04,
                  color: '#649df1',
                  fontWeight: '700',
                }}
                buttonName={'Giriş Yap'}
                onChange={() => {
                  navigation.navigate(RouteNames.LOGIN);
                }}
              />
            </View>
          </View>
        </View>
        <View style={{height: windowWidth * 0.2}}></View>
      </SafeAreaView>
    </ScrollView>
  );
};

export default Register;

const styles = StyleSheet.create({
  general: {alignItems: 'center'},
  shadow: {
    shadowOffset: {width: 4, height: 4},
  },
});

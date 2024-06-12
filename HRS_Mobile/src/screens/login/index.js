import {
  Image,
  SafeAreaView,
  StyleSheet,
  Text,
  View,
  Dimensions,
  TouchableOpacity,
  Alert,
} from 'react-native';
import React, {useState} from 'react';
import {TextInput, Button} from '../../components';
import {logo} from '../../assets/icons';
import {RouteNames, url} from '../../config';

const windowWidth = Dimensions.get('window').width;
const windowHeight = Dimensions.get('window').height;

const Login = props => {
  const {navigation} = props;
  const [tc, setTc] = useState('');
  const [password, setPassword] = useState('');
  console.log('url.baseUrl', url.baseUrl);
  const dataToSend = {
    tc: tc,
    password: password,
  };

  const kayitOl = () => {
    fetch(url.baseUrl + '/api/giris', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(dataToSend),
    })
      .then(response => response.json())
      .then(data => {
        console.log('Post isteği yanıtı:', data);
        if (!data.error) {
          navigation.navigate(RouteNames.HOME, {tc});
        } else {
          Alert.alert('TC kimlik no veya şifre hatalı');
        }
      })
      .catch(error => {
        console.error('Post isteği hatası:', error);
      });
  };
  return (
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
      <View style={{alignItems: 'center', marginVertical: windowWidth * 0.05}}>
        <View>
          <Text
            style={{
              fontSize: windowWidth * 0.06,
              fontWeight: '700',
              color: '#649df1',
            }}>
            Giriş Yap
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
              buttonName={'Giriş Yap'}
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
              buttonName={'Kayıt Ol'}
              onChange={() => {
                navigation.navigate(RouteNames.REGISTER);
              }}
            />
          </View>
        </View>
      </View>
    </SafeAreaView>
  );
};

export default Login;

const styles = StyleSheet.create({
  general: {alignItems: 'center'},
  shadow: {
    shadowOffset: {width: 4, height: 4},
  },
});

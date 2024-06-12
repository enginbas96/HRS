import {
  Dimensions,
  FlatList,
  Image,
  StyleSheet,
  Text,
  TouchableOpacity,
  View,
} from 'react-native';
import React, {useEffect, useState} from 'react';
import {plus} from '../../assets/icons';
import {DateCard} from '../../components';
import {RouteNames, url} from '../../config';

const windowWidth = Dimensions.get('window').width;
const windowHeight = Dimensions.get('window').height;

const Home = props => {
  const {navigation, route} = props;
  console.log('props', route.params.tc);
  const tc = route.params.tc;
  const [data, setData] = useState();
  const dataToSend = {
    tc: tc,
  };

  const randevu = () => {
    fetch(url.baseUrl + '/api/randevuMobil', {
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
          console.log('data.data', data.data);
          setData(data.data);
        }
      })
      .catch(error => {
        console.error('Post isteği hatası:', error);
      });
  };
  useEffect(() => {
    randevu();
  }, []);
  return (
    <View>
      <View
        style={{
          margin: windowWidth * 0.05,
          flexDirection: 'row',
          justifyContent: 'space-between',
        }}>
        <View>
          <Text
            style={{
              fontSize: windowWidth * 0.07,
              fontWeight: '800',
              color: 'black',
            }}>
            Randevularım
          </Text>
        </View>
        <TouchableOpacity
          onPress={() => {
            navigation.navigate(RouteNames.DATE, {tc});
          }}
          style={{
            padding: 5,
            backgroundColor: '#649df1',
            borderRadius: windowWidth,
          }}>
          <Image
            style={{
              width: windowWidth * 0.08,
              height: windowWidth * 0.08,
              tintColor: 'white',
            }}
            source={plus}
          />
        </TouchableOpacity>
      </View>
      <View style={{height: windowHeight * 0.87}}>
        <FlatList
          data={data}
          renderItem={({item}) => {
            console.log('item', item);
            return <DateCard data={item} />;
          }}
          keyExtractor={item => item.id}
        />
      </View>
    </View>
  );
};

export default Home;

const styles = StyleSheet.create({});

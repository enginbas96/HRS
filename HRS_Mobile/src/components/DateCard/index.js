import {Dimensions, StyleSheet, Text, View} from 'react-native';
import React from 'react';

const windowWidth = Dimensions.get('window').width;
const windowHeight = Dimensions.get('window').height;

const DateCard = props => {
  const {data} = props;
  return (
    <View>
      <View
        style={{
          alignItems: 'center',
          marginTop: windowWidth * 0.04,
        }}>
        <View
          style={{
            width: windowWidth * 0.8,
            backgroundColor: '#e1ecfe',
            borderRadius: windowWidth * 0.02,
            borderWidth: 1,
            justifyContent: 'center',
            paddingVertical: windowWidth * 0.03,
            paddingHorizontal: windowWidth * 0.03,
            borderColor: '#649df1',
          }}>
          <View
            style={{flexDirection: 'row', marginBottom: windowWidth * 0.02}}>
            <Text
              style={{
                fontSize: windowWidth * 0.04,
                fontWeight: '600',
                color: 'black',
              }}>
              Randevu Tarihi :
            </Text>
            <Text
              style={{
                fontSize: windowWidth * 0.04,
                color: 'black',
                marginLeft: 10,
              }}>
              {data.tarih}
            </Text>
          </View>
          <View
            style={{flexDirection: 'row', marginBottom: windowWidth * 0.02}}>
            <Text
              style={{
                fontSize: windowWidth * 0.04,
                fontWeight: '600',
                color: 'black',
              }}>
              Randevu Saati :
            </Text>
            <Text
              style={{
                fontSize: windowWidth * 0.04,
                color: 'black',
                marginLeft: 10,
              }}>
              {data.saat}
            </Text>
          </View>
          <View
            style={{flexDirection: 'row', marginBottom: windowWidth * 0.02}}>
            <Text
              style={{
                fontSize: windowWidth * 0.04,
                fontWeight: '600',
                color: 'black',
              }}>
              Poliklinik :
            </Text>
            <Text
              style={{
                fontSize: windowWidth * 0.04,
                color: 'black',
                marginLeft: 10,
              }}>
              {data.poliklinik}
            </Text>
          </View>
          <View
            style={{flexDirection: 'row', marginBottom: windowWidth * 0.02}}>
            <Text
              style={{
                fontSize: windowWidth * 0.04,
                fontWeight: '600',
                color: 'black',
              }}>
              Doktorun Adı :
            </Text>
            <Text
              style={{
                fontSize: windowWidth * 0.04,
                color: 'black',
                marginLeft: 10,
              }}>
              {data.doktorAd}
            </Text>
          </View>
          <View style={{flexDirection: 'row'}}>
            <Text
              style={{
                fontSize: windowWidth * 0.04,
                fontWeight: '600',
                color: 'black',
              }}>
              Hastane :
            </Text>
            <Text
              style={{
                fontSize: windowWidth * 0.04,
                color: 'black',
                marginLeft: 10,
              }}>
              {data.hastaneAdi}
            </Text>
          </View>
        </View>
      </View>
    </View>
  );
};

export default DateCard;

const styles = StyleSheet.create({});

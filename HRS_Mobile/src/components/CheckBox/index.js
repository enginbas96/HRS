import {title} from 'process';
import React, {useEffect, useState} from 'react';
import {
  Alert,
  Modal,
  StyleSheet,
  Text,
  Pressable,
  View,
  FlatList,
  Dimensions,
  TouchableOpacity,
} from 'react-native';
const windowWidth = Dimensions.get('window').width;
const windowHeight = Dimensions.get('window').height;
const Date = props => {
  const {name, DATA, onChange, onText, text} = props;
  const [modalVisible, setModalVisible] = useState(false);
  const [isData, setIsData] = useState();
  console.log('text', text);
  useEffect(() => {
    if (text === undefined) {
      setIsData();
    }
  }, [text]);
  const Item = item => {
    console.log('item', item);
    return (
      <TouchableOpacity
        onPress={() => {
          console.log('item', item);
          setModalVisible(false);
          setIsData(item);
          onText(item);
          onChange(item);
        }}
        style={styles.item}>
        <Text style={styles.title}>{item.name}</Text>
      </TouchableOpacity>
    );
  };
  return (
    <View style={styles.centeredView}>
      <Modal
        animationType="slide"
        transparent={true}
        visible={modalVisible}
        onRequestClose={() => {
          setModalVisible(!modalVisible);
        }}>
        <View style={styles.centeredView1}>
          <View style={styles.modalView}>
            <FlatList
              data={DATA}
              renderItem={({item}) => Item(item)}
              keyExtractor={item => item.id}
            />
          </View>
        </View>
      </Modal>
      <View>
        <View>
          <Text style={{fontSize: 17, fontWeight: '700', color: '#649df1'}}>
            {name}
          </Text>
        </View>
        <TouchableOpacity
          disabled={DATA?.lenght > 0 ? true : false}
          style={[styles.button]}
          onPress={() => setModalVisible(true)}>
          <Text style={styles.textStyle}>
            {isData ? isData.name : name + ' Seçiniz'}
          </Text>
        </TouchableOpacity>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  centeredView: {width: windowWidth, alignItems: 'center', marginVertical: 10},
  centeredView1: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: 'rgba(0, 0, 0, 0.4)',
  },
  modalView: {
    margin: 20,
    backgroundColor: 'white',
    borderRadius: 20,
    paddingVertical: 20,
    alignItems: 'center',
    shadowColor: '#000',
    shadowOffset: {
      width: 0,
      height: 2,
    },
    shadowOpacity: 0.25,
    shadowRadius: 4,
    elevation: 5,
    width: windowWidth * 0.8,
    height: windowWidth * 0.55,
  },
  button: {
    borderRadius: 10,
    padding: 10,
    elevation: 2,
    backgroundColor: '#e1ecfe',
    width: windowWidth * 0.8,
    borderColor: '#649df1',
    borderWidth: 1,
  },
  textStyle: {
    color: 'black',
    fontWeight: 'bold',
    textAlign: 'center',
  },
  modalText: {
    marginBottom: 15,
    textAlign: 'center',
  },
  item: {
    width: windowWidth * 0.8,
    alignItems: 'center',
    padding: 10,
  },
  title: {
    fontSize: 20,
    color: 'black',
  },
});

export default Date;

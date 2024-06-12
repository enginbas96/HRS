import {
  View,
  Text,
  Dimensions,
  TextInput,
  TouchableOpacity,
} from 'react-native';
import React from 'react';
import PropTypes from 'prop-types';

const windowWidth = Dimensions.get('window').width;
const windowHeight = Dimensions.get('window').height;

const TextInput2 = props => {
  const {textInputName, passwordText, color, onChangeText} = props;
  return (
    <View>
      <View
        style={{
          alignItems: 'center',
          marginTop: windowWidth * 0.04,
        }}>
        <View>
          <View style={{marginBottom: windowWidth * 0.01}}>
            <Text
              style={{
                fontSize: windowWidth * 0.04,
                fontWeight: '600',
                color: 'black',
              }}>
              {textInputName}
            </Text>
          </View>
          <View
            style={{
              width: windowWidth * 0.8,
              height: windowWidth * 0.12,
              backgroundColor: '#e1ecfe',
              borderRadius: windowWidth * 0.02,
              borderWidth: 1,
              justifyContent: 'center',
              paddingVertical: windowWidth * 0.01,
              paddingHorizontal: windowWidth * 0.03,
              borderColor: '#649df1',
            }}>
            <TextInput
              style={{height: windowWidth * 0.12}}
              secureTextEntry={passwordText}
              onChangeText={onChangeText}
            />
          </View>
        </View>
      </View>
    </View>
  );
};

TextInput2.propsTypes = {
  textInputName: PropTypes.string,
  passwordText: PropTypes.bool,
  style: PropTypes.oneOfType(PropTypes.object, PropTypes.array),
  number: PropTypes.number,
  control: PropTypes.func,
};
TextInput2.defaultProps = {
  style: {backgroundColor: 'red'},
  passwordText: false,
  textInputName: 'Text Alanı',
  control: () => {
    console.log('control buton');
  },
};

export default TextInput2;

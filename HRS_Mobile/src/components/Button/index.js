import {View, Text, TouchableOpacity, Dimensions} from 'react-native';
import React from 'react';
const windowWidth = Dimensions.get('window').width;
const windowHeight = Dimensions.get('window').height;
import PropTypes from 'prop-types';

const Button = props => {
  const {style, textStyle, buttonName, onChange} = props;
  return (
    <View>
      <TouchableOpacity onPress={onChange} style={style}>
        <Text style={textStyle}>{buttonName}</Text>
      </TouchableOpacity>
    </View>
  );
};

Button.propsTypes = {
  style: PropTypes.oneOfType([PropTypes.object, PropTypes.array]),
  textStyle: PropTypes.oneOfType([PropTypes.object, PropTypes.array]),
  buttonName: PropTypes.string,
  onChange: PropTypes.func,
};
Button.defaultProps = {
  style: {
    bacgroundColor: 'white',
  },
  buttonName: 'Button',
  onChange: () => {
    console.log('Button Çalıştı');
  },
};

export default Button;

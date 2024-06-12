import * as React from 'react';
import {NavigationContainer} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';
import {Home, Date, Login, Register} from '../screens';
import {RouteNames} from '../config';
const Stack = createNativeStackNavigator();

export default StackNav = () => {
  return (
    <Stack.Navigator
      initialRouteName={RouteNames.LOGIN}
      screenOptions={{headerShown: false}}>
      <Stack.Screen name={RouteNames.HOME} component={Home} />
      <Stack.Screen name={RouteNames.DATE} component={Date} />
      <Stack.Screen name={RouteNames.LOGIN} component={Login} />
      <Stack.Screen name={RouteNames.REGISTER} component={Register} />
    </Stack.Navigator>
  );
};

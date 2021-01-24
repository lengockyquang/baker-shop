import React, { useEffect, useMemo, useState } from 'react';
// import { Container, Row, Cell } from '@idtek/component';
// import { Form, TextField, PasswordField } from '@idtek/form';
// import * as ApiConstant from '../constant/ApiConstant';
// import AppUtil from '../utils/AppUtil';
// import { useAppContext } from '../context/Context';
import _ from 'lodash';
import { checkLoginApi, getListGroup } from '../../constant/ApiConstant';
import AppUtil from '../../Utils/AppUtil';
import { useDispatch, useSelector } from 'react-redux';

import { message } from 'antd';
import { RootState } from '../../reducers';
import { setToken } from '../../actions';

interface AppState {
    userName: string,
    password: string
}

const stateDefault: AppState = {
    userName: '',
    password: ''
};


const Login = (): JSX.Element => {
    // const { setMask, setAuthData, setLanguage } = useAppContext()!;

    const userData = useSelector((state: RootState) => {
        return state.authen;
    });
    const dispatch = useDispatch();


    console.log('🚀 ~ file: Login.tsx ~ line 28 ~ hobbyList', userData);

    const [appState, setAppState] = useState<AppState>(stateDefault);


    // const LoginModel = {

    //     fields: {
    //         Username: {
    //             placeholder: Translate('Username'),
    //             hideLabel: true,
    //             required: true
    //         },
    //         Password: {
    //             placeholder: Translate('Password'),
    //             hideLabel: true,
    //             required: true
    //         }
    //     }
    // };

    const formRef: any = React.useRef(null);

    // useEffect(() => {
    //     checkLogin();
    // }, []);

    // const getLanguage = async (): Promise<void> => {
    //     try {
    //         const response = await AppUtil.axios.get(languageApi);
    //         const responseData = _.get(response, 'data', []);
    //         if (_.get(responseData, 'success', false)) {
    //             const language = _.get(responseData, 'results', {});
    //             setLanguage(language);
    //         }
    //     } catch (error) {
    //         console.log(error);
    //     }
    // };

    const handleLogin = async (): Promise<void> => {
        // if (formRef && formRef.current && formRef.current.isValid()) {
        //     setMask(true);
        //     const values = formRef.current.getValues();
        //     try {
        //         const response = await AppUtil.axios.post(ApiConstant.loginApi, values);
        //         const success = _.get(response, 'data.success', false);
        //         if (success) {
        //             window.location.reload();
        //         }
        //     } catch (error) {
        //         console.log(error);
        //     } finally {
        //         _.delay(() => {
        //             setMask(false);
        //         }, 100);
        //     }
        // }
    };

    const checkLogin = async (): Promise<void> => {
        try {


            // const result = _.get(response, 'data.results', undefined);
            // if (success) {
            //     getLanguage();
            //     setAuthData(result);
            // }
        } catch (error) {
            console.log(error);
        } finally {
            // _.delay(() => {
            //     setMask(false);
            // }, 100);
        }
    };

    const handleChange = (event: any) => {
        const name = event.target.name;
        const value = event.target.value;
        setAppState({
            ...appState,
            [name]: value
        });
    };

    const setToken = (userToken: string) => {
        sessionStorage.setItem('token', JSON.stringify(userToken));
    };

    const getToken = () => {
        //
    };


    const handleSubmit = async (event: any) => {
        try {
            event.preventDefault();
            const dataPost = {
                userName: appState.userName,
                password: appState.password,
                rememberMe: false,
            };

            // setMask(true);
            const response = await AppUtil.Axios.post(checkLoginApi, dataPost);
            const dataRespone = _.get(response, 'data');


            const success = _.get(dataRespone, 'success', false);
            const messageRes = _.get(dataRespone, 'message');

            if (success) {
                const token = _.get(dataRespone, 'results.token');

                const actionSetToken = setToken(token);
                dispatch(actionSetToken);

            } else {
                message.error(messageRes || 'Error!');
            }
        } catch (error) {
            console.log('🚀 ~ file: Login.tsx ~ line 118 ~ handleSubmit ~ error', error);
        }
    };


    return (
        <div>
            Login view
            <form onSubmit={handleSubmit}>
                <label>
                    User Name:
                    </label>
                <input type="text" name="userName" onChange={handleChange} />
                <label>
                    Password:
                    </label>
                <input type="text" name="password" onChange={handleChange} />
                <button type="submit">submit</button>
            </form>
        </div>

    );




};

export default Login;
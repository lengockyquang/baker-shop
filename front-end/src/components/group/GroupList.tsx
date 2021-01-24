import React, { useEffect, useState } from 'react';
import PropTypes from 'prop-types';
import Loading from '../loading/Loading';
import AppUtil from '../../Utils/AppUtil';
import { getListGroup } from '../../constant/ApiConstant';
import _ from 'lodash';

GroupList.propTypes = {

};

interface IGroup {
    loading: boolean,
    data: []
}


function GroupList(props: any) {

    const [appState, setAppState] = useState<IGroup>({
        loading: true,
        data: []
    });

    useEffect(() => {
        fetchData();
    }, []);

    const fetchData = async () => {
        try {
            const response = await AppUtil.Axios.get(getListGroup);
            console.log('🚀 ~ file: GroupList.tsx ~ line 32 ~ fetchData ~ response', response);


            const success = _.get(response, 'data.success', false);

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


    if (appState.loading)
        return <Loading />;


    return (
        <div>
            Group
        </div>
    );
}

export default GroupList;
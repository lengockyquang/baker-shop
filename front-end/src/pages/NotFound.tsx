import React from 'react';
import PropTypes from 'prop-types';
import { Link } from 'react-router-dom';

NotFound.propTypes = {

};

function NotFound(props: any) {
    return (
        <div style={{
            background: '#fff',
            flex: 1,
            display: 'flex',
            alignItems: 'center',
            justifyContent: 'center',
            flexDirection: 'column'
        }}>
            <span style={{
                fontSize: 20
            }}>
                Trang này không tồn tại
         </span>
            <Link to="/register">
                Trở lại Trang Chủ.
        </Link>
        </div>
    );
}

export default NotFound;
import React from 'react';
import PropTypes from 'prop-types';
import { useHistory } from 'react-router-dom';

CategoriesList.propTypes = {

};

function CategoriesList(props: any) {
    const history = useHistory();

    return (
        <div>
            cate

            <button onClick={() => {
                history && history.push('/admin/product');
            }}>
                product</button>

        </div>

    );
}

export default CategoriesList;
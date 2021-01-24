const initialState = {
    token: null,
    isLogin: false
};

const authenReducer = (state = initialState, action) => {
    switch (action.type) {
        case 'SET_TOKEN': {
            return {
                ...state,
                token: action.payload,
            };
        }
        default:
            return state;
    }
};

export default authenReducer;

export const addHobby = (hobby) => {
    return {
        type: 'ADD_HOBBY',
        payload: hobby
    };
};

export const setActiveHobby = (activeId) => {
    return {
        type: 'SET_ACTIVE_HOBBY',
        payload: activeId,
    };
};


export const setToken = (token) => {
    return {
        type: 'SET_TOKEN',
        payload: token
    };
};

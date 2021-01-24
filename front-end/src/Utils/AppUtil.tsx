

import lodash from 'lodash';
import axios from 'axios';
import { useHistory } from 'react-router-dom';

export default class AppUtil {
    static _ = lodash;
    static Axios = axios;

}

// export function PushUrl(url: string): void {
//     const history = useHistory();
//     history && history.push(url);
// }

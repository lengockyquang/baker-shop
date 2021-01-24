import React from 'react';
import PropTypes from 'prop-types';
import AppRoute from './AppRoute';
import Login from './login/Login';
import GroupList from './group/GroupList';

Layout.propTypes = {

};

function Layout(props: any) {


    const isAuthenticated = false;
    if (!isAuthenticated) {
        return <Login />;
    }

    return <GroupList />;



    // return (
    //     <div className="layout-page">
    //         {/* <HeaderPage /> */}
    //         <div
    //             style={{
    //                 overflow: 'auto',
    //                 // height: this.state.height,
    //                 position: 'relative',
    //                 top: 0
    //             }}
    //         >
    //             <div
    //                 style={{
    //                     display: 'flex',
    //                     flexDirection: 'column',
    //                     // minHeight: this.state.height - FOOTER_HEIGHT
    //                 }}
    //             >
    //                 <AppRoute />
    //             </div>
    //             {/* <Footer /> */}
    //         </div>
    //     </div>
    // );
}

export default Layout;



// import React from "react";
// import { connect } from "react-redux";
// import HeaderPage from "./Header";
// import Footer from "./Footer";
// import AppRoute from "../../AppRoute";
// import AuthLoading from "../../pages/AuthLoading";
// import { HEADER_HEIGHT, FOOTER_HEIGHT } from "../constants/constant";
// import { changeLayoutHeight } from "../actions/action";
// import AppUtil from "../../utils/AppUtil";
// import LoginPage from "../../LoginPage";
// import Idle from "./Idle";

// import "./Layout.scss";

// class Layout extends React.PureComponent {

//     constructor(props) {
//         super(props);
//         const height = window.innerHeight - HEADER_HEIGHT;
//         this.state = {
//             height: height
//         };
//         AppUtil.GetDispatcher()(changeLayoutHeight(height));
//         this.onResizeLayout = this.onResizeLayout.bind(this);
//     }

//     resizeTimer = null;

//     onResizeLayout() {
//         clearTimeout(this.resizeTimer);
//         const me = this;
//         this.resizeTimer = setTimeout(() => {
//             const height = window.innerHeight - HEADER_HEIGHT;
//             me.setState({ height }, () => {
//                 AppUtil.GetDispatcher()(changeLayoutHeight(height));
//             });
//         }, 50);
//     }

//     componentDidMount() {
//         window.addEventListener("resize", this.onResizeLayout, false);
//     }

//     componentWillUnmount() {
//         window.removeEventListener("resize", this.onResizeLayout, false);
//     }

//     render() {
//         const { isAuthenticated } = this.props;
//         if (!isAuthenticated) {
//             return <LoginPage />;
//         }
//         return (
//             <div className="layout-page">
//                 <HeaderPage />
//                 <div
//                     style={{
//                         overflow: 'auto',
//                         height: this.state.height,
//                         position: 'relative',
//                         top: 0
//                     }}
//                 >
//                     <div
//                         style={{
//                             display: 'flex',
//                             flexDirection: 'column',
//                             minHeight: this.state.height - FOOTER_HEIGHT
//                         }}
//                     >
//                         <AppRoute />
//                     </div>
//                     <Footer />
//                 </div>
//                 <AuthLoading />
//                 <Idle />
//             </div>
//         );
//     }
// }

// const mapStateToProps = (state) => {
//     const stateJs = state.toJS();
//     return { isAuthenticated: stateJs.root && stateJs.root.isAuthenticated };
// };

// export default connect(mapStateToProps)(Layout);

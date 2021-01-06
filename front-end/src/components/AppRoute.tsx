import React, { Suspense } from 'react';
import PropTypes from 'prop-types';
import { Switch, Route } from 'react-router-dom';
import Loading from './loading/Loading';
import { AdminRoutes, Routes } from '../routes';
import NotFound from '../pages/NotFound';

AppRoute.propTypes = {

};

function AppRoute(props: any) {
    return (
        <Suspense fallback={<Loading />}>
            <Switch>
                {
                    Routes.map((route) => {
                        const { id, component, exact } = route;
                        return (
                            <Route
                                key={id}
                                exact={exact}
                                path={id}
                                component={component}
                            />
                        );
                    })
                }
                {
                    AdminRoutes.map((route) => {
                        const { id, component: Component, exact } = route;
                        return (
                            <Route
                                key={id}
                                exact={exact}
                                path={id}
                                render={routeProps => (
                                    <Component {...routeProps} />
                                )}
                            />
                        );
                    })
                }
                <Route path={'*'} component={NotFound} />
            </Switch>
        </Suspense>
    );
}

export default AppRoute;


// import React, { Suspense } from 'react';
// import { connect } from 'react-redux';
// import { Switch, Route } from 'react-router-dom';
// import Routes, { AdminRoutes } from './routes';
// import Loading from './pages/Loading';
// import Admin from './modules/admin/Admin';
// import NotFound from './pages/NotFound';
// import AppUtil from './utils/AppUtil';
// import RightUtil from './utils/RightUtil';

// const AppRoute = ({ isAuthenticated, userRights }) => {
//     const filterRoutes = isAuthenticated ? AppUtil.DataUtil.filter(Routes, (o) => o.rights ? RightUtil.checkRight(o.rights, userRights) : true) : [];
//     const filterAdminRoutes = isAuthenticated ? AppUtil.DataUtil.filter(AdminRoutes, (o) => o.rights ? RightUtil.checkRight(o.rights, userRights) : true) : [];
//     return (
//         <Suspense fallback={<Loading />}>
//             <Switch>
//                 {
//                     filterRoutes.map((route) => {
//                         const { id, component, exact } = route;
//                         return (
//                             <Route
//                                 key={id}
//                                 exact={exact}
//                                 path={id}
//                                 component={component}
//                                 breadcrumb=''
//                             />
//                         );
//                     })
//                 }
//                 {
//                     filterAdminRoutes.map((route) => {
//                         const { id, component: Component, exact } = route;
//                         return (
//                             <Route
//                                 key={id}
//                                 exact={exact}
//                                 path={id}
//                                 breadcrumb=''
//                                 render={routeProps => (
//                                     <Admin>
//                                         <Component {...routeProps} />
//                                     </Admin>
//                                 )}
//                             />
//                         );
//                     })
//                 }
//                 <Route path={'*'} component={NotFound} />
//             </Switch>
//         </Suspense>
//     );
// };

// const mapStateToProps = (state) => {
//     const root = state.toJS().root;
//     return {
//         isAuthenticated: root.isAuthenticated,
//         userRights: root.userRights
//     };
// };

// export default connect(mapStateToProps)(AppRoute);

import { lazy } from 'react';

const Categories = lazy(() => import('./modules/admin/categories/CategoriesList'));
const Product = lazy(() => import('./modules/admin/products/ProductList'));


// const RegisterRoom = lazy(() => import('./modules/registerRoom/Register'));
// const MeetingSchedule = lazy(() => import('./modules/meetingSchedule/Index'));
// const Approve = lazy(() => import('./modules/approve/Index'));
// const Statistic = lazy(() => import('./modules/statistic/StatisticResultView'));

// // admin pages
// const Admin = lazy(() => import('./modules/admin/Admin'));
// const AdminConfig = lazy(() => import('./modules/admin/config/SystemConfig'));
// const AdminUser = lazy(() => import('./modules/admin/user/UserList'));
// const AdminLdapUserView = lazy(() => import('./modules/admin/user/LdapUserView'));
// const AdminLocation = lazy(() => import('./modules/admin/location/LocationList'));
// const AdminAuthSystem = lazy(() => import('./modules/admin/authSystem/components/AuthSystemListView'));
// const AdminAuthSystemUpdateView = lazy(() => import('./modules/admin/authSystem/components/AuthSystemUpdateView'));
// const AdminRoom = lazy(() => import('./modules/admin/room/RoomList'));
// const AdminOutsideRoomList = lazy(() => import('./modules/admin/outsideRoom/OutsideRoomList'));
// const AdminHistoryAccessListView = lazy(() => import('./modules/admin/historyAccess/HistoryAccessListView'));
// const ExportConfigView = lazy(() => import('./modules/admin/exportConfig/ExportConfig'));
// const StatisticDetailView = lazy(() => import('./modules/statistic/StatisticDetailView'));
// // --- admin pages

// export const Routes = [
//     { id: '/approve', component: Approve, rights: ['APPROVE_REGISTER_RIGHT_ACCESS'] },
//     { id: '/register', component: RegisterRoom },
//     { id: '/meeting-schedule', component: MeetingSchedule },
//     { id: '/statistic', component: Statistic },
//     { id: '/admin', component: Admin, exact: true, rights: ['ADMIN_RIGHT_ACCESS'] }
// ];


export const Routes = [
    // { id: '/approve', component: Approve, rights: ['APPROVE_REGISTER_RIGHT_ACCESS'] },
    // { id: '/register', component: RegisterRoom },
    // { id: '/meeting-schedule', component: MeetingSchedule },
    // { id: '/statistic', component: Statistic },
    // { id: '/admin', component: Admin, exact: true, rights: ['ADMIN_RIGHT_ACCESS'] }
];

export const AdminRoutes = [
    { id: '/admin/categories', component: Categories, exact: true },
    { id: '/admin/product', component: Product, exact: true },


];


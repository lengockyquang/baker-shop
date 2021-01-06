import React from 'react';
import './App.css';
import { Provider } from 'react-redux';
import store from './store';
import Layout from './components/Layout';
import { HashRouter as Router, Switch } from 'react-router-dom';

function App() {
  return (
    <div className="App">
      <Provider store={store}>
        <Router>
          <Switch>
            <Layout />
          </Switch>
        </Router>
      </Provider>
    </div>
  );
}

export default App;

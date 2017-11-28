import Vue from 'vue'
import App from './App.vue'
import axios from 'axios'
import VueAxios from 'vue-axios'

import 'bootstrap/dist/css/bootstrap.css';

Vue.use(VueAxios, axios);
Vue.axios.defaults.baseURL = 'http://localhost:5000/api';

new Vue({
  el: '#app',
  render: h => h(App)
})

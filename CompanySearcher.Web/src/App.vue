<template>
  <div id="app">
    <nav class="navbar navbar-light">
      <a class="navbar-brand" href="#">Company Searcher</a>
    </nav>
    <div class="container">
      <form v-on:submit.prevent class="get-company-code">
        <div class="form-group">
          <label>KRS/NIP/REGON</label>
          <input type="text" class="form-control" v-model="companyCode" id="companyCode">
        </div>
        <button class="btn btn-primary" v-on:click="fetch">Pobierz dane</button>
      </form>
      <form>
        <div class="form-group">
          <label class="control-label">Nazwa</label>
          <span class="form-control">Firma</span>
        </div>
        <div class="form-group">
          <div>
            <label>Ulica</label>
            <span class="form-control">Ulica</span>
          </div>
          <div>
            <label>Nr</label>
            <span class="form-control">Nr</span>
          </div>
        </div>
        <div class="form-group">
          <div>
            <label>Kod pocztowy</label>
            <span class="form-control">{{companyCode}}</span>
          </div>
          <div>
            <label>Miasto</label>
            <span class="form-control">{{post.title}}</span>
          </div>
        </div>        
      </form>
    </div>    
  </div>
</template>

<script>
import axios from 'axios'

export default {
  name: 'app',
  data () {
    return {
      post: "",
      companyCode: ""
    }
  },
  methods: {
    fetch() {
axios.get(`http://jsonplaceholder.typicode.com/posts/`+this.companyCode)
    .then(response => {
      // JSON responses are automatically parsed.
      this.post = response.data
    })
    .catch(e => {
      this.errors.push(e)
    })
    }
  }
}
</script>

<style>
input {
  max-width: 300px;
}
.navbar {
  background-color: #e3f2fd;
  margin-bottom: 50px;
}
.get-company-code {
  margin-bottom: 50px;
}
</style>

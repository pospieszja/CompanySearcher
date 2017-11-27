<template>
  <div id="app">
    <nav class="navbar navbar-light">
      <a class="navbar-brand" href="#">Company Searcher</a>
    </nav>
    <div class="container">
      <form  class="get-company-code">
        <div class="form-group">
          <label>KRS/NIP/REGON</label>
          <input type="text" class="form-control" v-model="companyCode" id="companyCode">
        </div>
        <button class="btn btn-primary" v-on:click.prevent="fetch">Pobierz dane</button>
      </form>
      <div v-if="notFound" class="alert alert-danger">
        <span>Nie znaleziono danych !!!</span>
      </div>      
      <form>
        <div class="form-group">
          <label class="control-label">Nazwa</label>
          <span class="form-control">{{ company.name }}</span>
        </div>
        <div class="form-group">
          <div>
            <label>Ulica</label>
            <span class="form-control">{{ company.street }}</span>
          </div>
          <div>
            <label>Nr</label>
            <span class="form-control">{{ company.streetNumber }}</span>
          </div>
        </div>
        <div class="form-group">
          <div>
            <label>Kod pocztowy</label>
            <span class="form-control">{{ company.postalCode }}</span>
          </div>
          <div>
            <label>Miasto</label>
            <span class="form-control">{{ company.city }}</span>
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
      company: {name: "", street: "", streetNumber: "", city: "", postalCode: "" },
      companyCode: "",
      notFound: false
    }
  },
  methods: {
    resetModel() {
      this.company.name = ""
      this.company.street = ""
      this.company.streetNumber = ""
      this.company.city = ""
      this.company.postalCode = ""
    },

    fetch() {
      this.resetModel()
      axios.get('http://localhost:5000/api/companies?companycode='+this.companyCode)
            .then(response => {
              this.company = response.data
              this.notFound = false
      })
      .catch(e => {
        this.notFound = true
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

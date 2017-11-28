<template>
  <div id="app">
    <nav class="navbar navbar-light">
      <a class="navbar-brand" href="#">Company Searcher</a>
    </nav>
    <div class="container">

      <form class="get-company-code">
        <div class="form-group">
          <label>KRS/NIP/REGON</label>
          <input type="text" class="form-control" v-model="companyCode" id="companyCode">
        </div>
        <button class="btn btn-primary" v-on:click.prevent="fetch">Pobierz dane</button>
      </form>

      <div v-if="notFound" class="alert alert-danger">
        <span>Nie znaleziono danych !!!</span>
      </div>    

      <div v-if="fetched" class="company-data">
        <div class="row">
          <div class="col-xs-12">
            <label class="col-xs-12">Nazwa</label>
            <input type="text" class="col-xs-12" v-model="company.name">
          </div>
        </div>

        <div class="row">
          <div class="col-xs-12 col-md-10">
            <label class="col-xs-12">Ulica</label>
            <input type="text" class="col-xs-12" v-model="company.street">
          </div>
          <div class="col-xs-12 col-md-2">
            <label class="col-xs-12">Nr</label>
            <input type="text" class="col-xs-12" v-model="company.streetNumber">
          </div>
        </div>
        <div class="row">
          <div class="col-xs-12 col-md-4">
            <label class="col-xs-12">Kod pocztowy</label>
            <input type="text" class="col-xs-12" v-model="company.postalCode">
          </div>
          <div class="col-xs-12 col-md-8">
            <label class="col-xs-12">Miasto</label>
            <input type="text" class="col-xs-12 postal-code" v-model="company.city">
          </div>
       </div>
      </div>
    </div>    
  </div>
</template>

<script>
export default {
  name: "app",
  data() {
    return {
      company: {
        name: "",
        street: "",
        streetNumber: "",
        city: "",
        postalCode: ""
      },
      companyCode: "",
      notFound: false,
      fetched: false
    };
  },
  
  methods: {
    resetModel() {
      this.company.name = "";
      this.company.street = "";
      this.company.streetNumber = "";
      this.company.city = "";
      this.company.postalCode = "";
    },
    fetch() {
      this.resetModel();
      this.fetched = true;
      this.axios
        .get("/companies",{params: {companyCode: this.companyCode}})
        .then(response => {
          this.company = response.data;
          this.notFound = false;
        })
        .catch(e => {
          this.notFound = true;
        });
    }
  }
};
</script>

<style>
.navbar {
  background-color: #e3f2fd;
  margin-bottom: 50px;
}
.get-company-code {
  margin-bottom: 50px;
}
.company-data, form {
  max-width: 550px;
}
.company-data input {
  margin-bottom: 10px;
}

.company-data input {
  padding: 3px;
}
</style>

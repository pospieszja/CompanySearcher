<template>
  <div id="app">
    <nav class="navbar navbar-light">
      <a class="navbar-brand" href="#">Company Searcher</a>
    </nav>
    <div class="container">
      <form class="get-company-code">
        <div class="form-group">
          <label>KRS/NIP/REGON</label>
          <input type="text" class="form-control" id="companyCode">
        </div>
        <button class="btn btn-primary">Pobierz dane</button>
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
            <span class="form-control">Kod pocztowy</span>
          </div>
          <div>
            <label>Miasto</label>
            <span class="form-control">Miasto</span>
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

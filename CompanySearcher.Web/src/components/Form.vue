<template>
<form>
  <div class="form-group">
    <label for="exampleInputEmail1">KRS/NIP/REGON</label>
    <input type="text" class="form-control" id="companyCode">
  </div>
  <button class="btn btn-primary" v-on:click="this.showCompany = !this.showCompany">Pobierz dane {{this.showCompany}}</button>
</form>
</template>

<script>
export default {
  props: ['showCompany'],
  name: 'Form',
  data () {
    return {
    }
  },
mounted() {
    fetch(`http://localhost:5000/api/company/4567KRS`)
      .then(response => response.json())
      .then((data) => {
        this.company = data;
      })
 }
}
</script>
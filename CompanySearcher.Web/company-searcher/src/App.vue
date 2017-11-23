<template>
  <div id="app">
    <nav class="navbar navbar-light">
      <a class="navbar-brand" href="#">Company Searcher</a>
    </nav>
    <div class="container">
      <Form v-bind:showCompany="showCompany"/>
      <Company v-show="showCompany"/>
    </div>
  </div>
</template>

<script>
import HelloWorld from './components/HelloWorld'
import Form from './components/Form'
import Company from './components/Company'

export default {
  name: 'app',
  components: {
    HelloWorld,
    Form,
    Company
  },
  data() {
    return {
      showCompany: true
    }
  }
}
</script>

<style>
.navbar {
  background-color: #e3f2fd;
  margin-bottom: 50px;
}
</style>
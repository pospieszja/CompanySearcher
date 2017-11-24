<template>
<div>
  <p>company</p>
</div>
</template>

<script>
export default {
  name: 'Company',
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
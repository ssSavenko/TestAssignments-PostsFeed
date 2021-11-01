
const home = {
  template:`
  <div>
  <h1 style="text-align:center;">Select Post</h1>  
  <ul style="list-style-type:none; margin-top: 50px;">
    <li v-for="item in feedData" style="display:flex; flex-direction: row; margin: 10px"> 
        <img style="width: 200px; margin:0 50px" v-bind:src="'data:image/jpeg;base64, '+item.icon">
        <div style="display:flex; flex-direction: column;">
            <h2><a v-bind:href="'#/post?post='+item.pageNum" >{{item.name}}</a></h2>
            <div>
                <p>{{item.overview}}</p> 
            </div>
        </div>
    </li>
  </ul> 


  <div style="position: relative; width: 100%; ">
  <a style="position: absolute; left:0px; " v-if="isPrev"  href="./#Home" v-on:click="ToPrevPage">Prev</a>
  <a style="position: absolute; right:0px;" v-if="isNext"  href="./#Home" v-on:click="ToNextPage">Next</a>
  </div>
  </div> `,

  data(){
      return{
        feedData:[], 
          isNext: false,
          isPrev: false,
          numOfPage: 0,
          nextPage: 0,
          prevPage: 0
      }
  },

  methods:{
    refreshData(){   
        axios.get(variables.API_URL+"Home?page="+this.numOfPage)
        .then((response)=>{ 
            this.feedData = response.data.resultList;
            this.isPrev = response.data.hasPrev;
            this.isNext = response.data.hasNext; 
        });
        
      this.$forceUpdate(); 
    },
    initPage(){ 
        this.numOfPage  = this.$route.query.page;
        if(this.numOfPage == undefined){
            this.numOfPage=0;
        }
        this.nextPage = this.numOfPage+1
        this.prevPage = this.numOfPage-1
    } ,
    
    ToNextPage()
    {
        this.numOfPage++;
        this.nextPage = this.numOfPage+1
        this.prevPage = this.numOfPage-1
        this.refreshData();
    }, 
    ToPrevPage(){
        console.log("a");
        this.numOfPage--;
        this.nextPage = this.numOfPage+1
        this.prevPage = this.numOfPage-1
        this.refreshData();
    }
    },

  watch: {  
    }, 

  mounted:function(){
      this.initPage();
      this.refreshData(); 
  }
}

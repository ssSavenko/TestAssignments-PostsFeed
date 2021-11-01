Date.prototype.yyyymmdd = function() {
    var mm = this.getMonth() + 1; // getMonth() is zero-based
    var dd = this.getDate();
  
    return [this.getFullYear()+"/",
            (mm>9 ? '' : '0') + mm+"/",
            (dd>9 ? '' : '0') + dd
           ].join('');
  };



const post = {
    template:`
    <div style="margin-bottom: 200px;">
    <h1 style="text-align:center;
    margin: 10px;">{{postInfo.name}}</h1>
    <p style="text-align: right;">{{creationDate}}</p>
    
    <img v-if="postInfo.icon != ''" style=" height: 200px; margin: 0 auto; display: block;" v-bind:src="'data:image/jpeg;base64, '+postInfo.icon"">
    <ul style="list-style-type:none; margin-top: 50px;" v-for="item in postData" >
    <li style="display:flex; margin: 10px;align-items: center;" :style="item.isHorizontal?'flex-direction=row;':''">  
    <img v-if="item.image != '' &&  item.image != undefined" style="margin:0 50px;max-width: calc( 60% - 100px);" v-bind:src="'data:image/jpeg;base64, '+item.image"">
    <p style="white-space: pre-line;">{{item.text}}</p> 
    </li>
    </ul>
    <p style="font-size:36px;">Comments</p>
<div style="width: 50%; margin: 0 auto; display: block;">
        <p>Your's comment <span v-if="isFromUnavailable" style="color: red">Posted</span></p>
        <input minlength="3" maxlength="64" :disabled="isFromUnavailable" style="width: 100%; margin: 10px 0;" placeholder="name" v-model="name"/>
        <textarea  type="textarea" minlength="10" maxlength="256" :disabled="isFromUnavailable" style="width: 100%; margin: 10px 0;" placeholder="message" v-model="message"/> 
        <button :disabled="isFromUnavailable"  v-on:click="sendData" style="display: block; margin: 0 auto;">Set Comment</button>
    </div>

<div >

<ul style="list-style-type:none; margin-top: 50px;"  v-for="item in commentsData" >
<li >
<p style="font-size: 28px;">{{item.usersName}}</p>
<p style="font-size: 20px;">{{item.text}}</p>
<hr>
</li>
</ul> 
</div>

    </div>`,
  
    data(){
        return{ 
            postInfo: {},
            postData: {},
            commentsData: {},
            creationDate:{},
            name: "",
            message:"",
            isFromUnavailable: false
        }
    },
    
  
    methods:{
      refreshData(){   
          this.numOfPost  = this.$route.query.post;  

           axios.get(variables.API_URL+"Home/Post/"+this.numOfPost)
           .then((response)=>{   
               this.postInfo = response.data.postInfo;
               this.postData = response.data.postItems;
               this.commentsData = response.data.comments;
               this.creationDate = new Date(response.data.postInfo.createdOn).yyyymmdd();  
               console.log(this.commentsData);
           });

        },

        sendData(){  
            if(this.name != "" && this.message != ""){
                this.isFromUnavailable = true;    
                axios.post(variables.API_URL+"Home/Post/"+this.numOfPost,{name: this.name, message: this.message, postsNum: this.numOfPost})
            }
        }
    },
  
    mounted:function(){ 
        this.refreshData();
    }
  }
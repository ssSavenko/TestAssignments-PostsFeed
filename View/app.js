const headers = {  
}

const routes=[
    {path:'/home',component:home},
    {path:'/post',component:post}
]

const router=new VueRouter({
    routes
})

const app = new Vue({
    router
}).$mount('#app')

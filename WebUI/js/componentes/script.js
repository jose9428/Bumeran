Vue.component('vue_select', {
template: `
    <select>
        <option>Peru</option>
        <option>Lima</option>
    </select>
`
        })

        Vue.component('navbar', {
        template: `
        <nav class="navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row">
       <div class="text-center navbar-brand-wrapper d-flex align-items-center justify-content-center">
           <a class="navbar-brand brand-logo mr-5" href="index.html"><img src="https://www.bumeran.com.pe/candidate/static/media/bumeran.296e6bc2.svg" class="mr-2" alt="logo"/></a>
           <a class="navbar-brand brand-logo-mini" href="index.html"><img src="https://www.bumeran.com.pe/candidate/static/media/bumeran.296e6bc2.svg" alt="logo"/></a>
       </div>
       <div class="navbar-menu-wrapper d-flex align-items-center justify-content-end">
           <button class="navbar-toggler navbar-toggler align-self-center" type="button" data-toggle="minimize">
               <span class="ti-view-list"></span>
           </button>

           <ul class="navbar-nav navbar-nav-right">
           </ul>
           <button class="navbar-toggler navbar-toggler-right d-lg-none align-self-center" type="button" data-toggle="offcanvas">
               <span class="ti-view-list"></span>
           </button>
       </div>
   </nav>
`
                })

        Vue.component('sidebar', {
        template: `
      <nav class="sidebar sidebar-offcanvas" id="sidebar">
        <ul class="nav">
            <li class="nav-item">
                <a class="nav-link" href="Publicaciones.html">
                    <i class="ti-files menu-icon"></i>
                    <span class="menu-title">Publicaciones</span>
                </a>
            </li>

            <li class="nav-item">
                <a class="nav-link" href="Postulantes.html">
                    <i class="ti-user menu-icon"></i>
                    <span class="menu-title">Postulante</span>
                </a>
            </li>
        </ul>
    </nav>

`
                })

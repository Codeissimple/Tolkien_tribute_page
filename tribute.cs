/* Common */
html {
  background: url(https://www.tomswallpapers.com/pic/201512/1080x1920/tomswallpapers.com-32471.jpg) no-repeat center center fixed;
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
  scroll-behavior: smooth;
  box-sizing: border-box;
  margin: 0;
}

.wrapper {
  position: relative;
  display: column;
  margin-left: 10%;
  margin-right: 10%;
}
#navigate_div{
  background-color: green;
  text-color: blue;
}


#navigate_div ul {
  display: table;
  width: 100%;
}

#navigate_div ul li {
  list-style: none;
  display: table-cell;
  width: 25%;
  padding-top: 10px;
  padding-bottom:10px;

}

#navigate_div a{
  font-family: 'gothic' Fallback 'Serif';
  color: white;
  font-size:14px;
  font-weight: bold;
  padding-top: 10px;
  padding-bottom:10px;
  padding-right: 10px;
  padding-left: 10px;

}
#navigate_div a:hover{
  background-color: orange;
}

/* Applying the same style for the title bloc and a footer */
.title_block, .my_footer {
     position: relative;
     width: auto;
     display:flex;
     padding: 20px;
     margin-bottom: 20px;
     margin-top: 30px;
     background: rgba(255, 255, 255, .8);
}

#logo {
  margin-bottom: 10vh;
}

.title_block{
  display: flex;
  flex-direction: column;
  align-items: center;
  background: none;
}

#image {
  border-radius: 50%;
  margin: auto;
  width:200px;
  border: 3px solid green;
  padding: 10px;
}

.article {
  position: relative;
  min-height: 60vh;
  min-width: auto;
  background: rgba(255, 255, 255, .8);
  margin-bottom: 20vh;
}
.container {
  display: flex;
  flex-direction: column;
  align-items: center;
  margin: 0 auto;
  max-width: 1200px;
  padding: 0 1rem;
  overflow: auto;
  height: calc(70vh);
}
.responsive-image {
  max-width: 100%;
}
.cell img {
  display: block;
}

@media screen and (min-width: 600px) {
  .container{
    overflow: auto;
    height: calc(70vh);
  }
  .grid {
    display: flex;
    flex-wrap: wrap;
    flex-direction: row;
  }
  .cell {
    width: calc(50% - 2rem);
  }
}

@media screen and (min-width: 1000px) {
  .container{
    overflow: auto;
    max-height: 80vh;
  }
  .cell {
    width: calc(33.3333% - 2rem);
  }
}

.cell {
  margin: 1rem;
}

/*================
==================
==================
*/


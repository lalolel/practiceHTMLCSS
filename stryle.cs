html, body {
  margin: 0;
  padding: 0;
}

body {
  font-family: 'Roboto', sans-serif;
  font-weight: 100;
}

.container {
  margin: 0 auto;
  max-width: 940px; 
  padding: 0 10px;
}

.header {
  background: url(https://content.codecademy.com/projects/innovation-cloud/bg.jpg) no-repeat center center; 
  background-size: cover;
  height: 800px;
  text-align: center; 
}

.header .container {
  position: relative;
  top: 200px;
}

.header h1 {
  color: #fff;
  line-height: 100px; 
  font-size: 80px;
  margin-top: 0;
  margin-bottom: 80px;
  text-transform: uppercase; 
}

@media (min-width:850px) {
  .header h1 {
    font-size: 120px;
  }
}

.header p {
  color: #fff;
  font-weight: 500;
  letter-spacing: 8px;
  margin-bottom: 40px;
  margin-top: 0;
  text-transform: uppercase; 
}

.btn {
  color: #fff;
  background: #000;
  padding: 10px 40px;
  text-decoration: none; 
  transition: background .5s; 
}

.nav { 
  background: #000;
  height: 80px; 
  width: 100%;
}

.nav ul {
  height: 80px;
  list-style: none;
  margin: 0 auto; 
  padding: 0;
}

.nav ul li {
  color: #fff;
  display: inline-block; 
  height: 80px;
  line-height: 80px; 
  list-style: none;
  padding: 0 10px;
  transition: background .5s; 
}

.btn:hover, .nav ul li:hover {
  background: #117bff;
  cursor: pointer; 
  transition: background .5s;  
}

.main .container {
  margin: 80px auto;
}

.main img {
  float: left;
  margin: 50px 80px 50px 0;
}

.jumbotron {
  background: url(https://content.codecademy.com/projects/innovation-cloud/jumbotron_bg.jpg) center center;
  background-size: cover;
  height: 600px; 
}

.jumbotron .container {
  position: relative;
  top: 220px;
}

.jumbotron h2 {
  color: #fff;
  text-align: right; 
}

.jumbotron p {
  color: #fff; 
  text-align: right; 
}

.jumbotron .btn {
  margin: 10px 0 0;
  float: right; 
}

.footer { 
  background: #000;
  height: 80px; 
  padding-bottom: 50px;
}

.footer p { 
  color: #fff;
  font-size: 14px;  
  height: 80px; 
  line-height: 80px;
  margin: 0;  
}

@media (max-width: 500px) {
  .header h1 {
    font-size: 50px;
    line-height: 64px;
  }

  .main, .jumbotron {
    padding: 0 30px;
  }

  .main img {
    width: 100%;
  }
}

* {
    box-sizing: border-box;
    padding: 0;
    margin: 0;
}

body {
    background-color: #d9dcd6;
}

.header {
    padding: 20px;
    font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
    background-color: #2a607c;
    color: #ffffff;
}

.header h1 {
    display: inline-block;
    font-size: 48px;
}

/* Changed SEO color to white so the title can blend better */
.header h1 .seo {
    color: #ffffff;
}

.header div {
    padding-top: 15px;
    margin-right: 20px;
    float: right;
    font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
    font-size: 20px;
}

.header div ul {
    list-style-type: none;
}

.header div ul li {
    display: inline-block;
    margin-left: 25px;
}

a {
    color: #ffffff;
    text-decoration: none;
}

p {
    font-size: 16px;
}



.hero {
    height: 800px;
    width: 100%;
    margin-bottom: 25px;
    background-image: url("../images/digital-marketing-meeting.jpg");
    background-size: cover;
    background-position: center;
}

.float-left {
    float: left;
    margin-right: 25px;
}

.float-right {
    float: right;
    margin-left: 25px;
}

.content {
    width: 75%;
    display: inline-block;
    margin-left: 20px;
}

.benefits {
    margin-right: 20px;
    padding: 20px;
    clear: both;
    float: right;
    width: 20%;
    height: 100%;
    font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
    background-color: #2589bd;
}
/*Condensed all h3 tags to save the css space*/

h3{
    margin-bottom: 10px;
    text-align: center;

}
/* Condensed all Box  properties to save the css space */
.benefit-lead, .benefit-cost, .benefit-brand   {
    margin-bottom: 32px;
    color: #ffffff;
}



/* Condensed img block to save css space */
.benefit-lead img, 
.benefit-brand img, 
.benefit-cost img {
    display: block;
    margin: 10px auto;
    max-width: 150px;

}

/* Condensed all Box propeties to save the css space */
.search-engine-optimization,
.online-reputation-management, 
.social-media-marketing {
    margin-bottom: 20px;
    padding: 50px;
    height: 300px;
    font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
    background-color: #0072bb;
    color: #ffffff;
}

/* Condensed all img height to save css size */
.search-engine-optimization img,
.online-reputation-management img,
.social-media-marketing img {
    max-height: 200px;
}

/* Condensed all h2 margins and font size  */
.search-engine-optimization h2,
.online-reputation-management h2,
.social-media-marketing h2{
    margin-bottom: 20px;
    font-size: 36px;
}

.footer {
    padding: 30px;
    clear: both;
    font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
    text-align: center;
}
.footer h2 {
    font-size: 20px;
}
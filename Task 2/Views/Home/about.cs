@{
    ViewBag.Title = "About";
}

< h2 > About </ h2 >
< p > @ViewBag.Message </ p >

< nav >
    < a href = "@Url.Action("Index", "Home")">Home</a> |
    <a href="@Url.Action("About", "Home")">About</a> |
    <a href="@Url.Action("Books", "Home")">Books</a>
</nav>

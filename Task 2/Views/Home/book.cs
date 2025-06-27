using BookHaven.Models;
using System.Reflection;
using System.Threading;

@model IEnumerable<BookHaven.Models.Book>

@{
    ViewBag.Title = "Books";
}
< h2 > Books </ h2 >

< table border = "1" >
    < thead >
        < tr >
            < th > Title </ th >
            < th > Author </ th >
            < th > Year </ th >
        </ tr >
    </ thead >
    < tbody >
        @foreach(var book in Model)
        {
            < tr >
                < td > @book.Title </ td >
                < td > @book.Author </ td >
                < td > @book.Year </ td >
            </ tr >
        }
    </ tbody >
</ table >

< nav >
    < a href = "@Url.Action("Index", "Home")">Home</a> |
    <a href="@Url.Action("About", "Home")">About</a> |
    <a href="@Url.Action("Books", "Home")">Books</a>
</nav>

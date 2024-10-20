@model MyMvcApp.Models.BookModel

<h2>Edit Book</h2>

<form asp-controller="Forms" asp-action="EditBooks">
    <input type="hidden" asp-for="BookId" />

    <div>
        <label>Book Name :</label>
        <input asp-for="BookName" class="form-control" type="text" />
        <span asp-validation-for="BookName" class="text-danger"></span>
    </div>

    <div>
        <label>Book Author :</label>
        <input asp-for="Author" class="form-control" type="text" />
        <span asp-validation-for="Author" class="text-danger"></span>
    </div>

    <div>
        <label>Book Price :</label>
        <input asp-for="Price" class="form-control" type="number" step="0.01" />
        <span asp-validation-for="Price" class="text-danger"></span>
    </div>

    <div>
        <label>Book Date :</label>
        <input asp-for="Date" class="form-control" type="date" />
        <span asp-validation-for="Date" class="text-danger"></span>
    </div>

    <button type="submit" class="btn btn-primary">Save Changes</button>
</form>

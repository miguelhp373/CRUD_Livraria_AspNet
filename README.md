# WebSite Livraria com Asp.Net Core MVC

Miguel Henrique Pereira  3M - PW3 - Professor Madureira - ETECVAV

25/09/2021

---

## Home

![Untitled](.github/Untitled.png)

## Lista de Livros

![Untitled](.github/Untitled%201.png)

## Editar Livros

![Untitled].github/Untitled%202.png)

## Detalhes

![Untitled](.github/Untitled%203.png)

## Apagar

![Untitled](.github/Untitled%204.png)

## Privacidade

![Untitled](.github/Untitled%205.png)

---

## Código Fonte:

_Layout.cshtml

```html
<!doctype html>
<html lang="en">
<head>
    <title>@ViewData["Title"]</title>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS v5.0.2 -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">

    <link rel="stylesheet" href="~/css/site.css"/>
    <style>
        .navbar-brand {
            font-size: 24px !important;
        }

        .menu-left-nav > li > a {
            text-decoration: none !important;
            color: #ffff !important;
            font-size: 20px !important;
            transition: 0.2s;
        }

        .menu-left-nav > li > a:hover {
            filter: brightness(50%);
        }
    </style>
</head>

<body>
    <nav class="navbar navbar-expand-sm|md|lg|-xl navbar-dark bg-dark">
        <div class="container">
            <a class="navbar-brand" href="#">Livros Infos</a>
            <button class="navbar-toggler d-lg-none" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavId" aria-controls="collapsibleNavId"
                    aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <ul class="nav d-flex justify-content-start menu-left-nav">
                <li class="nav-item">
                    <a class="nav-link active" asp-area="" asp-page="/Index">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/Livros">Livros</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" asp-area="" asp-page="/Privacy">Privacidade</a>
                </li>
            </ul>
        </div>
    </nav>
    <main role="main">
        @RenderBody()
    </main>

    <footer class="border-top footer text-muted" style="background-color: #212529;">
        <div class="container" style="color: #FFFF;">
            &copy; 2021 - Livros Infos - <a asp-area="" asp-page="/Privacy">Privacidade</a>
        </div>
    </footer>

    <!-- Bootstrap JavaScript Libraries -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>
    <script src="https://kit.fontawesome.com/bb41ae50aa.js" crossorigin="anonymous"></script>
    @await RenderSectionAsync("Scripts", required: false)
</body>
</html>
```

index.cshtml

```html
<!doctype html>
<html lang="en">
<head>
    <title>@ViewData["Title"]</title>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS v5.0.2 -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">

    <link rel="stylesheet" href="~/css/site.css"/>
    <style>
        .navbar-brand {
            font-size: 24px !important;
        }

        .menu-left-nav > li > a {
            text-decoration: none !important;
            color: #ffff !important;
            font-size: 20px !important;
            transition: 0.2s;
        }

        .menu-left-nav > li > a:hover {
            filter: brightness(50%);
        }
    </style>
</head>

<body>
    <nav class="navbar navbar-expand-sm|md|lg|-xl navbar-dark bg-dark">
        <div class="container">
            <a class="navbar-brand" href="#">Livros Infos</a>
            <button class="navbar-toggler d-lg-none" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavId" aria-controls="collapsibleNavId"
                    aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <ul class="nav d-flex justify-content-start menu-left-nav">
                <li class="nav-item">
                    <a class="nav-link active" asp-area="" asp-page="/Index">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/Livros">Livros</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" asp-area="" asp-page="/Privacy">Privacidade</a>
                </li>
            </ul>
        </div>
    </nav>
    <main role="main">
        @RenderBody()
    </main>

    <footer class="border-top footer text-muted" style="background-color: #212529;">
        <div class="container" style="color: #FFFF;">
            &copy; 2021 - Livros Infos - <a asp-area="" asp-page="/Privacy">Privacidade</a>
        </div>
    </footer>

    <!-- Bootstrap JavaScript Libraries -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>
    <script src="https://kit.fontawesome.com/bb41ae50aa.js" crossorigin="anonymous"></script>
    @await RenderSectionAsync("Scripts", required: false)
</body>
</html>
```

models/Livro.cs

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Crud.Models
{
    public class Livro
    {
        [Key]//anotação para identificar a chave primária
        public int Id_Livro { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Editora { get; set; }
        public int Isbn { get; set; }
        public int Ano { get; set; }
        [Required]
        public string Autor { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }
    }
}
```
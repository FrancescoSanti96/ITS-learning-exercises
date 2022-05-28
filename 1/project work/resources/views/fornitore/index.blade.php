<!DOCTYPE html>
<html>
<head>
  <style>
     h2,th{
        text-align:left;
        color: rgb(3, 44, 28)
       }
    body{
        background-color: rgb(148, 168, 111);
    }
    a{
        color: rgb(3, 44, 28);
    }
  </style>
</head>
<body>
    @include('common.menu')
<h2><em> Elenco Fornitori</em></h2>

<table style="width:100%">
  <tr>
    <th>Nome Fornitore</th>
    <th>Referente</th>
    <th>indirizzo</th>
    <th>CAP</th>
    <th>City</th>
    <th>Country</th>
    <th>Email</th>
    <th>Phone</th><br><br>
  </tr>
  @foreach ($items as $item)
  <tr>
    <td><a href="/fornitores/{{$item->id}}/edit">{{$item->nome}}</a></td>
    <td>{{$item->referente}}</td>
    <td>{{$item->indirizzo}}</td>
    <td>{{$item->cap}}</td>
    <td>{{$item->city}}</td>
    <td>{{$item->country}}</td>
    <td>{{$item->email}}</td>
    <td>{{$item->phone}}</td>
    <td>
        <form action="/fornitores/{{$item->id}}" method="POST">
        @csrf
        @method('DELETE')
        <input type="submit" value="DELETE">
        </form>
    </td>
  </tr>
  @endforeach
</table>
<br>
<br>
<br>
<a href="{{route('fornitores.create')}}"> Create New Fornitore</a>

</body>


</html>

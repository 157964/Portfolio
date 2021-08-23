@extends('app')

@section('content')
<table class="table">
    <thead>
    <td>Blauw:</td>
    <td>Wit:</td>
    <td>Winnaar:</td>
    <td>Actie:</td>
    </thead>
    <tbody>
    @foreach($wedstrijden as $wedstrijd)
    <tr>
        <td>{{$wedstrijd->deelnemerblauw->naam}}</td>
        <td>{{$wedstrijd->deelnemerwit->naam}}</td>
        <td>{{$wedstrijd->winnaar}}</td>
        <td>
            <a href="{{ route('wedstrijden.edit', $wedstrijd->id)}}" class="btn btn-primary">Wijzig</a>
            <form action="{{ url('/wedstrijden', $wedstrijd->id) }}" method="post">
                @method('DELETE')
                @csrf
                <input type="submit" value="Delete" class="btn btn-primary"/>
            </form>
        </td>

    </tr>
    @endforeach
    <tr>
        <td>
            <a href="{{ route('wedstrijden.create')}}" class="btn btn-primary">Nieuwe wedstrijd</a>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    </tbody>
</table>
@endsection

@extends('app')

@section('content')
<table class="table">
    <thead>
        <td>Naam:</td>
        <td>Band:</td>
        <td>Keer gewonnen:</td>
        <td>Keer verloren:</td>
        <td>Actie:</td>
    </thead>
    <tbody>
    @foreach($deelnemers as $deelnemer)
        <tr>
            <td>{{$deelnemer->naam}}</td>
            <td>{{$deelnemer->banden->NL_naam}}</td>
            <td>{{$deelnemer->win}}</td>
            <td>{{$deelnemer->loss}}</td>
            <td>
                <a href="{{ route('deelnemer.edit', $deelnemer->id)}}" class="btn btn-primary">Wijzig</a>
                <form action="{{ url('/deelnemer', $deelnemer->id) }}" method="post">
                    @method('DELETE')
                    @csrf
                    <input type="submit" value="Delete" class="btn btn-primary"/>
                </form>
            </td>
        </tr>
    @endforeach
    <tr>
        <td>
            <a href="{{ route('deelnemer.create')}}" class="btn btn-primary">Nieuwe Deelnemer</a>
        </td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    </tbody>
</table>
@endsection

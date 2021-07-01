@extends('app')

@section('content')
<form method="post" action="{{ route('wedstrijden.update', $wedstrijd->id) }}">
    <div class="form-group">
        @method('PATCH')
        @csrf
        <label>Blauw:</label>

        <select class="form-control" name="blauwe_judoka" required>
            @foreach($deelnemers as $deelnemer)
            <option value="{{$deelnemer->id}}"
            >{{$deelnemer->naam}}</option>
            @endforeach
        </select>

    </div>
    <div class="form-group">
        <label>Wit:</label>

        <select class="form-control" name="witte_judoka" required>
            @foreach($deelnemers as $deelnemer)
            <option value="{{$deelnemer->id}}">{{$deelnemer->naam}}</option>
            @endforeach
        </select>

    </div>
    <div class="form-group">
        <p>Winnaar:</p>

        <input type="radio" value="blauw" name="winnaar" id="radioBlauw">
        <label for="radioBlauw">Blauw</label>
        <input type="radio" value="wit" name="winnaar" id="radioWit">
        <label for="radioWit">Wit</label>
    </div>
    <button type="submit" class="btn btn-primary">Aanpassen</button>
</form>
@endsection

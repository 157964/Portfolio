@extends('app')

@section('content')
<form method="post" action="{{ route('deelnemer.store') }}">
    <div class="form-group">
        @csrf
        <label>Naam:</label>
        <input type="text" class="form-control" name="naam"/>
    </div>
    <div class="form-group">
        <label>Band</label>
        <select class="form-control" name="banden_id" required>
            @foreach($banden as $band)
            <option value="{{$band->id}}">{{$band->NL_naam}}</option>
            @endforeach
        </select>
    </div>
    <div class="form-group">
        <label>Aantal keer gewonnen:</label>
        <input type="text" class="form-control" name="win"/>
    </div>
    <div class="form-group">
        <label>Aantal keer verloren:</label>
        <input type="text" class="form-control" name="loss"/>
    </div>
    <button type="submit" class="btn btn-primary">Toevoegen</button>
</form>
@endsection

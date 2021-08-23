<?php

use Illuminate\Database\Seeder;

class BandenSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table('banden')->insert([
            'id' => 1,
            'NL_naam' => 'Witte Band',
            'JP_naam' => '6e Kyu'
        ]);
        DB::table('banden')->insert([
            'id' => 2,
            'NL_naam' => 'Gele Band',
            'JP_naam' => '5e Kyu'
        ]);
        DB::table('banden')->insert([
            'id' => 3,
            'NL_naam' => 'Oranje Band',
            'JP_naam' => '4e Kyu'
        ]);
        DB::table('banden')->insert([
            'id' => 4,
            'NL_naam' => 'Groene Band',
            'JP_naam' => '3e Kyu'
        ]);
        DB::table('banden')->insert([
            'id' => 5,
            'NL_naam' => 'Blauwe Band',
            'JP_naam' => '2e Kyu'
        ]);
        DB::table('banden')->insert([
            'id' => 6,
            'NL_naam' => 'Bruine Band',
            'JP_naam' => '1e Kyu'
        ]);
        DB::table('banden')->insert([
            'id' => 7,
            'NL_naam' => 'Zwarte Band',
            'JP_naam' => 'Shodan'
        ]);
    }
}
